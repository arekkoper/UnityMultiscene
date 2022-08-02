using System;
using System.Collections;
using UnityEngine;

namespace Game
{
    public class ExampleLevel : GameState
    {
        public static event Action OnExampleLevel;

        public override void EnterState()
        {
            OnExampleLevel?.Invoke();
        }

        public override void UpdateState()
        {
        }

    }
}