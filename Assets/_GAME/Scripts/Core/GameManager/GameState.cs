using System;
using System.Collections;
using UnityEngine;

namespace Game
{
    public abstract class GameState
    {
        private GameManager _manager;

        public GameManager Manager { get => _manager; set => _manager = value; }

        public abstract void EnterState();
        public abstract void UpdateState();
    }
}