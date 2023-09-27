using System.IO;
using UnityEditor;
using UnityEngine;

namespace ZenoxZX.Core.Editor
{
#if UNITY_EDITOR
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

        private static readonly string[] ScriptSubFolderNames =
        {
            "Components",
            "Datas",
            "Events",
            "Extensions",
            "Installers",
            "Utils"
        };
        
        private static readonly string[] ComponentSubFolderNames =
        {
            "Login",
            "Main"
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

            foreach (string folderName in ScriptSubFolderNames)
            {
                string path = $"{mainPath}/Scripts/{folderName}";
                if (!Directory.Exists(path))
                    AssetDatabase.CreateFolder("Assets/Scripts", folderName);
            }
            
            foreach (string folderName in ComponentSubFolderNames)
            {
                string path = $"{mainPath}/Scripts/Components/{folderName}";
                if (!Directory.Exists(path))
                    AssetDatabase.CreateFolder("Assets/Scripts/Components", folderName);
            }
        }
    }
    #endif
}