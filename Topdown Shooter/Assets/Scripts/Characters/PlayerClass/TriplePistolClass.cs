using UnityEngine;
using Weapons;

namespace Characters.PlayerClass
{
    public class TriplePistolClass : Player
    {
        [SerializeField] private Weapon weaponOne;
        [SerializeField] private Weapon weaponTwo;
        [SerializeField] private Weapon weaponThree;
        protected override void ProcessInputs()
        {
            if(Input.GetMouseButtonDown(0))
            {
                weaponOne.Fire();
                weaponTwo.Fire();
                weaponThree.Fire();
                
            }
            base.ProcessInputs();
        }
    }
}
