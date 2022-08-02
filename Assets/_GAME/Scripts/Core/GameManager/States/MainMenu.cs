using System;

namespace Game
{
    public class MainMenu : GameState
    {
        public override void EnterState()
        {
            UnloadScene(GameManager.EXAMPLE_LEVEL);
            UnloadScene(GameManager.EXAMPLE_LEVEL_UI);
            LoadScene(GameManager.MAIN_MENU_UI);
        }

        public override void UpdateState()
        {

        }

    }
}
