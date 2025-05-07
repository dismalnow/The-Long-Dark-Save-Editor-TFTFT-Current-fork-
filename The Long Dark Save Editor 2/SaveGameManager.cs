using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Long_Dark_Save_Editor_2
{
    public class SaveGameManager
    {
        public static string[] GetSaveFiles()
        {
            List<string> saveFiles = new List<string>();
            
            // Get pre-TFTFT save files (in root folder)
            string baseFolder = Helpers.Util.GetLocalPath();
            string oldSavePath = Path.Combine(baseFolder, "Hinterland", "TheLongDark");
            if (Directory.Exists(oldSavePath))
            {
                saveFiles.AddRange(Directory.GetFiles(oldSavePath, "*", SearchOption.TopDirectoryOnly)
                    .Where(f => !Path.GetFileName(f).StartsWith("user") && 
                           !Path.GetFileName(f).EndsWith(".backup") &&
                           !f.Contains("profile_") &&
                           !Path.GetFileName(f).StartsWith(".")));
            }
            
            // Get TFTFT save files (in Survival subfolder)
            string tftftSavePath = Path.Combine(oldSavePath, "Survival");
            if (Directory.Exists(tftftSavePath))
            {
                saveFiles.AddRange(Directory.GetFiles(tftftSavePath, "*", SearchOption.TopDirectoryOnly)
                    .Where(f => !Path.GetFileName(f).StartsWith("user") && 
                           !Path.GetFileName(f).EndsWith(".backup") &&
                           !f.Contains("profile_") &&
                           !Path.GetFileName(f).StartsWith(".")));
            }
            
            return saveFiles.ToArray();
        }

        public static string GetBackupPath(string savePath)
        {
            string directory = Path.GetDirectoryName(savePath);
            string backupPath;
            
            // Handle TFTFT save files
            if (savePath.Contains("Survival"))
            {
                backupPath = Path.Combine(directory, "backups");
            }
            else
            {
                // For pre-TFTFT saves, create a backups folder in the same directory
                backupPath = Path.Combine(directory, "backups");
            }
            
            if (!Directory.Exists(backupPath))
            {
                Directory.CreateDirectory(backupPath);
            }
            
            return backupPath;
        }
    }
}
