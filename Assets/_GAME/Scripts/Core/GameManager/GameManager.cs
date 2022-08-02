using UnityEngine;

namespace Game
{
    public class GameManager : MonoBehaviour
    {        
        private GameState _currentState;

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
            _currentState.EnterState();
        }
    }
}


