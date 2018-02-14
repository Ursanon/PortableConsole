﻿#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace PortableConsole
{
    public class PortableConsoleResources : ScriptableObject
    {
        public Color FirstColor = Color.white;
        public Color SecondColor = Color.grey;
        public Sprite InfoSprite;
        public Sprite WarningSprite;
        public Sprite ErrorSprite;

        public Sprite GetLogTypeIconSprite(PortableConsoleLogType type)
        {
            switch (type)
            {
                case PortableConsoleLogType.Info:
                    return InfoSprite;
                case PortableConsoleLogType.Warning:
                    return WarningSprite;
                case PortableConsoleLogType.Error:
                default:
                    return ErrorSprite;
            }
        }

#if UNITY_EDITOR
        //todo: move it to portable console script (+ creator popup)
        [MenuItem("PortableConsole/CreateInstance")]
        public static void CreateInstance()
        {
            PortableConsoleResources resources = new PortableConsoleResources();
            AssetDatabase.CreateAsset(resources, "Assets/PortableConsole/Prefabs/PortableConsoleResources.asset");
        }
#endif
    }
}