using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace The_Long_Dark_Save_Editor_2.Helpers
{
    public static class Util
    {
        public static string GetLocalPath(bool testBranch = false)
        {
            try
            {
                string local;
                string path;
                
                if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                {
                    local = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                }
                else
                {
                    local = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".config/unity3d");
                }
                
                // Support for both the original install path and Steam path
                path = Path.Combine(local, testBranch ? "HinterlandTest2" : "Hinterland");
                
                return path;
            }
            catch (Exception)
            {
                return ".";
            }
        }

        public static bool IsTFTFTSave(string savePath)
        {
            // Check if the save path contains the Survival subfolder (TFTFT saves)
            return savePath.Contains(Path.Combine("TheLongDark", "Survival"));
        }

        public static string GetSaveProfilePath(string savePath)
        {
            // Determine the profile path based on the save path
            string directory = Path.GetDirectoryName(savePath);
            
            if (IsTFTFTSave(savePath))
            {
                // For TFTFT, check for profile files in the Survival folder
                var profiles = Directory.GetFiles(directory, "profile_survival*");
                if (profiles.Length > 0)
                {
                    // Return the most recent profile
                    return profiles.OrderByDescending(p => File.GetLastWriteTime(p)).First();
                }
                return null;
            }
            else
            {
                // For pre-TFTFT saves, check in the root TheLongDark folder
                string rootDir = Directory.GetParent(directory).FullName;
                var profiles = Directory.GetFiles(rootDir, "user*");
                if (profiles.Length > 0)
                {
                    // Return the most recent profile
                    return profiles.OrderByDescending(p => File.GetLastWriteTime(p)).First();
                }
                return null;
            }
        }

        public static string VersionString
        {
            get
            {
                Version v = Assembly.GetExecutingAssembly().GetName().Version;
                return $"{v.Major}.{v.Minor}.{v.Build}";
            }
        }

        // Any additional utility methods...
    }
}
