using System.Collections;
using UnityEngine;

namespace Game
{
    public class GameStateChangeUI : MonoBehaviour
    {
        [Header("Dependencies")]
        [SerializeField] private GameManager _gameManager;

        private void Awake()
        {
            _gameManager = FindObjectOfType<GameManager>();
        }

        public void NewGame()
        {
            _gameManager.ChangeState(new ExampleLevel());
        }

        public void Quit()
        {
            Application.Quit();
        }

        public void ReturnToMainMenu()
        {
            _gameManager.ChangeState(new MainMenu());
        }

    }
}