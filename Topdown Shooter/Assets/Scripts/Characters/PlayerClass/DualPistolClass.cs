using UnityEngine;
using Weapons;

namespace Characters.PlayerClass
{
    public class DualPistolClass : Player
    {
        [SerializeField] private Weapon weaponOne;
        [SerializeField] private Weapon weaponTwo;
        // Update is called once per frame
        public override void Update()
        {
            ProcessInputs();
        }

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
