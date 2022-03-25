using UnityEngine;
using Weapons;

namespace Characters.PlayerClass
{
    public class DualPistolClass : Player
    {
        [SerializeField] private Weapon weaponOne;
        [SerializeField] private Weapon weaponTwo;
        protected override void ProcessInputs()
        {
            if(Input.GetMouseButtonDown(0))
            {
                weaponOne.Fire();
                weaponTwo.Fire();
            }
            base.ProcessInputs();
        }
    }
}
