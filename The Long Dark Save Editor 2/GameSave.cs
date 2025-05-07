using System;
using System.Globalization;
using System.IO;
using System.Linq;
using The_Long_Dark_Save_Editor_2.Game_data;
using The_Long_Dark_Save_Editor_2.Helpers;
using The_Long_Dark_Save_Editor_2.Serialization;

namespace The_Long_Dark_Save_Editor_2
{
    public class GameSave
    {
        public static int MAX_BACKUPS = 20;

        public long LastSaved { get; set; }
        private DynamicSerializable<BootSaveGameFormat> dynamicBoot;
        public BootSaveGameFormat Boot { get { return dynamicBoot.Obj; } }

        private DynamicSerializable<GlobalSaveGameFormat> dynamicGlobal;
        public GlobalSaveGameFormat Global { get { return dynamicGlobal.Obj; } }

        public AfflictionsContainer Afflictions { get; set; }

        private DynamicSerializable<SlotData> dynamicSlotData;
        public SlotData SlotData { get { return dynamicSlotData.Obj; } }

        public string OriginalRegion { get; set; }

        public string path;
        
        // Flag indicating whether this is a TFTFT save
        public bool IsTFTFTSave { get; private set; }

        public void LoadSave(string path)
        {
            this.path = path;
            
            // Determine if this is a TFTFT save
            IsTFTFTSave = Util.IsTFTFTSave(path);
            
            try
            {
                string slotJson = EncryptString.Decompress(File.ReadAllBytes(path));
                dynamicSlotData = new DynamicSerializable<SlotData>(slotJson);

                var bootJson = EncryptString.Decompress(Convert.FromBase64String(SlotData.m_Dict["boot"]));
                dynamicBoot = new DynamicSerializable<BootSaveGameFormat>(bootJson);
                OriginalRegion = Boot.m_SceneName.Value;

                var globalJson = EncryptString.Decompress(Convert.FromBase64String(SlotData.m_Dict["global"]));
                dynamicGlobal = new DynamicSerializable<GlobalSaveGameFormat>(globalJson);

                Afflictions = new AfflictionsContainer(Global);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load save file: {ex.Message}", ex);
            }
        }

        public void Save()
        {
            Backup();

            LastSaved = DateTime.Now.Ticks;
            var bootSerialized = dynamicBoot.Serialize();
            SlotData.m_Dict["boot"] = Convert.ToBase64String(EncryptString.Compress(bootSerialized));
            var globalSerialized = dynamicGlobal.Serialize();
            SlotData.m_Dict["global"] = Convert.ToBase64String(EncryptString.Compress(globalSerialized));

            var toBeCompressed = dynamicSlotData.Serialize();
            File.WriteAllBytes(path, EncryptString.Compress(toBeCompressed));
        }

        public void Backup()
        {
            string backupFolder = SaveGameManager.GetBackupPath(path);
            
            // Get existing backups
            string[] currentBackups = Directory.GetFiles(backupFolder, "*.backup", SearchOption.TopDirectoryOnly);
            
            // Sort backups by creation time (oldest first)
            var orderedBackups = currentBackups
                .Select(f => new FileInfo(f))
                .OrderBy(f => f.CreationTime)
                .ToList();
            
            // Remove old backups if we have too many
            while (orderedBackups.Count >= MAX_BACKUPS)
            {
                var oldestBackup = orderedBackups[0];
                try
                {
                    File.Delete(oldestBackup.FullName);
                    orderedBackups.RemoveAt(0);
                }
                catch
                {
                    // Skip if we can't delete
                    break;
                }
            }
            
            // Create new backup with timestamp
            string backupName = $"{DateTime.Now:yyyy-MM-dd HH.mm.ss}-{Path.GetFileName(path)}.backup";
            string backupPath = Path.Combine(backupFolder, backupName);
            
            File.Copy(path, backupPath, true);
        }

        public static GameSave LoadFromFile(string path)
        {
            GameSave gameSave = new GameSave();
            gameSave.LoadSave(path);
            return gameSave;
        }
    }
}
