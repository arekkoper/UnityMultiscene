using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public abstract class GameState
    {
        private List<string> _scenesToLoad = new();
        private List<string> _scenesToUnload = new();
        private GameManager _manager;

        public GameManager Manager { get => _manager; set => _manager = value; }
        public List<string> ScenesToLoad { get => _scenesToLoad; set => _scenesToLoad = value; }
        public List<string> ScenesToUnload { get => _scenesToUnload; set => _scenesToUnload = value; }

        protected abstract void EnterState();
        public abstract void ReloadScenes();
        public abstract void UpdateState();


    }
}