using System;
using UnityEngine;

namespace Game
{
    public class MainMenu : GameState
    {

        public override void ReloadScenes()
        {
            ScenesToLoad.Add(GameManager.MAIN_MENU_UI);
            ScenesToUnload.Add(GameManager.EXAMPLE_LEVEL);
            ScenesToUnload.Add(GameManager.EXAMPLE_LEVEL_UI);

            EnterState();
        }

        protected override void EnterState()
        {
            Debug.Log("Enter Main Menu State");
        }

        public override void UpdateState()
        {

        }

    }
}
