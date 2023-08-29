using System.IO;
using UnityEditor;
using UnityEngine;

namespace ZenoxZX.Core.Editor
{
    public static class FolderInitializer
    {
        private static readonly string[] MainFolderNames =
        {
            "Art",
            "Scenes",
            "Scripts",
            "Resources",
            "SFX",
            "Sprites",
        };

        private static readonly string[] SubFolderNames =
        {
            "Components",
            "Datas",
            "Events",
            "Extensions",
            "Installers",
            "Utils"
        };

        [MenuItem("Help/Create Folder Structure")]
        private static void CreateFolders()
        {
            string mainPath = Application.dataPath;

            foreach (string folderName in MainFolderNames)
            {
                string path = Path.Combine(mainPath, folderName);
                if (!Directory.Exists(path))
                    AssetDatabase.CreateFolder("Assets", folderName);
            }

            foreach (string folderName in SubFolderNames)
            {
                string path = $"{mainPath}/Scripts/{folderName}";
                if (!Directory.Exists(path))
                    AssetDatabase.CreateFolder("Assets/Scripts", folderName);
            }
        }
    }
}