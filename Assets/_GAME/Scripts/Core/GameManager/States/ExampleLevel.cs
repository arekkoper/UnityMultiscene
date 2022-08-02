using System;
using System.Collections;
using UnityEngine;

namespace Game
{
    public class ExampleLevel : GameState
    {
        public override void EnterState()
        {
            UnloadScene(GameManager.MAIN_MENU_UI);
            LoadScene(GameManager.EXAMPLE_LEVEL);
            LoadScene(GameManager.EXAMPLE_LEVEL_UI);
        }

        public override void UpdateState()
        {
        }


    }
}