using System;
using UnityEngine;

namespace Game
{
    public class GameManager : MonoBehaviour
    {
        public event Action OnStateChange;

        public static readonly string MAIN_MENU_UI = "MainMenuUI";
        public static readonly string EXAMPLE_LEVEL = "ExampleLevelUI";
        public static readonly string EXAMPLE_LEVEL_UI = "ExampleLevel";

        private GameState _currentState;

        public GameState CurrentState { get => _currentState; set => _currentState = value; }

        private void Start()
        {
            ChangeState(new MainMenu());
        }

        private void Update()
        {
            _currentState.UpdateState();
        }

        public void ChangeState(GameState state)
        {
            state.Manager = this;
            _currentState = state;
            _currentState.ReloadScenes();
            OnStateChange?.Invoke();
        }
    }
}


