using Achievements;
using Interfaces;
using UnityEngine;

namespace Characters
{
    public class Enemy : Character, IDamageable
    {
        private GameObject _player;
        private float _currentHealth;
        
        public override void Start()
        {
            _player = GameObject.FindGameObjectWithTag("player");
            _currentHealth = CharacterData.health;
            base.Start();
        }
        
        public override void Update()
        {
            PlayerTrack();
            base.Update();
        }

        private void PlayerTrack()
        {
            var enemyTransform = transform;
            var position = _player.transform.position;
            var position1 = enemyTransform.position;
            position1 = Vector2.MoveTowards(position1, position,
                CharacterData.movementSpeed * Time.deltaTime);
            enemyTransform.position = position1;
            enemyTransform.up = position - position1;
        }
        public void Damage(float dmgAmount)
        {
            _currentHealth -= dmgAmount;
            if (_currentHealth <= 0)
            {
                AchievementsManager.Instance.UpdateAchievements(AchievementTypes.Kill, 1);
                Destroy(gameObject);
            }
        }
    }
}
