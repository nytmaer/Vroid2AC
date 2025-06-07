using UnityEngine;
using UnityEditor;
using VRoid2AC.Core;

namespace VRoid2AC.Editor
{
    public class VRoid2ACWindow : EditorWindow
    {
        private GameObject vrmAvatar;
        private string outputPath = "Assets/Exports/";

        [MenuItem("Window/VRoid2AC/Main Window")]
        public static void ShowWindow()
        {
            GetWindow<VRoid2ACWindow>("VRoid2AC Converter");
        }

        private void OnGUI()
        {
            GUILayout.Label("VRoid2AC Converter", EditorStyles.boldLabel);
            
            EditorGUILayout.Space();
            
            GUILayout.Label("Input", EditorStyles.boldLabel);
            vrmAvatar = (GameObject)EditorGUILayout.ObjectField("VRM Avatar", vrmAvatar, typeof(GameObject), true);
            
            EditorGUILayout.Space();
            
            GUILayout.Label("Settings", EditorStyles.boldLabel);
            outputPath = EditorGUILayout.TextField("Output Path", outputPath);
            
            EditorGUILayout.Space();
            
            if (GUILayout.Button("Convert to AC"))
            {
                ConvertToAC();
            }
        }

        private void ConvertToAC()
        {
            if (vrmAvatar == null)
            {
                EditorUtility.DisplayDialog("Error", "Please select a VRM avatar first.", "OK");
                return;
            }
            
            Debug.Log($"Converting {vrmAvatar.name}");
        }
    }
}
