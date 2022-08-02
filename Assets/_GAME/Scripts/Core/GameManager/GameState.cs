using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public abstract class GameState
    {
        private GameManager _manager;

        public GameManager Manager { get => _manager; set => _manager = value; }

        public abstract void EnterState();

        public abstract void UpdateState();

        protected void LoadScene(string sceneName)
        {
            SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        }

        protected void UnloadScene(string sceneName)
        {
            if (SceneManager.GetSceneByName(sceneName).isLoaded)
                SceneManager.UnloadSceneAsync(sceneName);
        }

    }
}