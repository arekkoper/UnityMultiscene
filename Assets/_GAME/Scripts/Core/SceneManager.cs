using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class SceneManager : MonoBehaviour
    {
        private static readonly string MAIN_MENU_UI = "MainMenuUI";
        private static readonly string EXAMPLE_LEVEL = "ExampleLevelUI";
        private static readonly string EXAMPLE_LEVEL_UI = "ExampleLevel";

        private void Awake()
        {
            MainMenu.OnMainMenu += MainMenu_OnMainMenu;
            ExampleLevel.OnExampleLevel += ExampleLevel_OnStateChoose;
        }

        private void ExampleLevel_OnStateChoose()
        {
            UnloadScene(MAIN_MENU_UI);
            LoadScene(EXAMPLE_LEVEL);
            LoadScene(EXAMPLE_LEVEL_UI);
        }

        private void MainMenu_OnMainMenu()
        {
            UnloadScene(EXAMPLE_LEVEL);
            UnloadScene(EXAMPLE_LEVEL_UI);
            LoadScene(MAIN_MENU_UI);
        }

        private void LoadScene(string sceneName)
        {
            UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        }

        private void UnloadScene(string sceneName)
        {
            if (UnityEngine.SceneManagement.SceneManager.GetSceneByName(sceneName).isLoaded)
                UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneName);
        }


    }
}