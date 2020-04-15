using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3AllinoneRandomizer
{
    public static class GamePath
    {
        private const string REG_PATH_STEAM = @"SOFTWARE\WOW6432Node\Valve\Steam\";
        private const string REG_KEYNAME_INSTALL = "InstallPath";

        private const string FOLDER_PATH_STEAMGAME = @"steamapps\common\";

        private const string FOLDER_PATH_DS3 = @"DARK SOULS III\Game\";

        private static string _mapstudioPath = string.Empty;

        private static string _backupPath = string.Empty;

        public static string GetBackupPath()
        {
            if (_backupPath == string.Empty)
                _backupPath = "";
            return _backupPath;
        }

        /// <summary>
        /// If failed, returns <see cref="string.Empty"/>
        /// </summary>
        public static string TryGetSteamGameRegistryPath()
        {
            try
            {
                return Registry.LocalMachine.OpenSubKey(REG_PATH_STEAM).GetValue(REG_KEYNAME_INSTALL).ToString() + "\\" + FOLDER_PATH_STEAMGAME + "\\" + FOLDER_PATH_DS3;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
