using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace ZenoxZX.Core.Editor
{
    #if UNITY_ANDROID && UNITY_EDITOR
    
    [InitializeOnLoad]
    public class AndroidSetup
    {
        static AndroidSetup() => Set();

        public static void Set()
        {
            PlayerSettings.keystorePass = "myPwd";
            PlayerSettings.keyaliasPass = "myAliasPwd";
            string keyStore = $"{PlayerSettings.productName}.keystore";
            string s = Application.dataPath + "/" + keyStore;
            if (!System.IO.File.Exists(s))
            {
                Debug.LogError("Key Store not found. Please create a keystore file in the project root folder. Name it : " + keyStore);
                Debug.LogError("at : " + s);
            }

            else
            {
                PlayerSettings.Android.keystoreName = Application.dataPath + "/user.keystore";
            }
            
        }
    }
#endif
}
