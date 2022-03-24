using UnityEngine;
using Weapons;

namespace Characters.PlayerClass
{
    public class SinglePistolClass : Player
    {
        [SerializeField] private Weapon weaponOne;
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
                
            }

            base.ProcessInputs();
        }
    }
}
