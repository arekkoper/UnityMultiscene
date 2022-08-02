using System;
using System.Collections;
using UnityEngine;

namespace Game
{
    public class ExampleLevel : GameState
    {
        public override void ReloadScenes()
        {
            ScenesToUnload.Add(GameManager.MAIN_MENU_UI);
            ScenesToLoad.Add(GameManager.EXAMPLE_LEVEL);
            ScenesToLoad.Add(GameManager.EXAMPLE_LEVEL_UI);

            EnterState();
        }

        protected override void EnterState()
        {
            Debug.Log("Enter Example Level State");
        }

        public override void UpdateState()
        {
        }


    }
}