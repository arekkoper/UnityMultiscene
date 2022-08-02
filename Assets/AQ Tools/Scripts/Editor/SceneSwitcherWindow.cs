#if UNITY_EDITOR
using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace AQ.Tools
{
    public class SceneSwitchWindow : EditorWindow
    {
        private Vector2 scrollPos;

        [MenuItem("Tools/Scene Switcher Window")]
        private static void ShowWindow()
        {
            var window = GetWindow<SceneSwitchWindow>();
            window.titleContent = new GUIContent("Scene Switcher");
            window.Show();
        }

        private void OnGUI()
        {
            EditorGUILayout.BeginVertical();
            scrollPos = EditorGUILayout.BeginScrollView(scrollPos, false, false);

            GUILayout.Label("Scenes", EditorStyles.boldLabel);

            for (int i = 0; i < EditorBuildSettings.scenes.Length; i++)
            {
                var scene = EditorBuildSettings.scenes[i];
                if (scene.enabled)
                {
                    var sceneName = Path.GetFileNameWithoutExtension(scene.path);
                    var pressed = GUILayout.Button(i + ": " + sceneName, new GUIStyle(GUI.skin.GetStyle("Button")) { alignment = TextAnchor.MiddleLeft });

                    if (pressed)
                    {
                        var activeScene = EditorSceneManager.GetActiveScene();
                        EditorSceneManager.SaveScene(activeScene, activeScene.path);
                        EditorSceneManager.OpenScene(scene.path);
                    }
                }
            }

            EditorGUILayout.EndScrollView();
            EditorGUILayout.EndVertical();

        }
    }
}
#endif