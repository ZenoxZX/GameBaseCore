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

        }
    }
#endif
}
