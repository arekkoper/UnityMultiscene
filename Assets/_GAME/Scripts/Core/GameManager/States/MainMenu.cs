using System;

namespace Game
{
    public class MainMenu : GameState
    {
        public static event Action OnMainMenu;

        public override void EnterState()
        {
            OnMainMenu?.Invoke();
        }

        public override void UpdateState()
        {

        }
    }
}
