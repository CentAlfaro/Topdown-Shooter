using Achievements;
using UnityEngine;
using Weapons;

namespace Characters.PlayerClass
{
    public class SinglePistolClass : Player
    {
        [SerializeField] private Weapon weaponOne;
        protected override void ProcessInputs()
        {
            base.ProcessInputs();
            if(Input.GetMouseButtonDown(0))
            {
                weaponOne.Fire();
                AchievementsManager.Instance.UpdateAchievements(AchievementTypes.ButtonPress, 1);
                
            }
        }
    }
}
