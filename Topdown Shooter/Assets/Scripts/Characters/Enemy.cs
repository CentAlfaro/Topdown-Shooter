using UnityEngine;

namespace Characters
{
    public class Enemy : Character
    {
        private GameObject _playerTracked;
        public float enemyHealth = 100;
        
        public override void Start()
        {
            _playerTracked = GameObject.FindGameObjectWithTag("player");
            base.Start();
        }
        
        public override void Update()
        {
            PlayerTrack();
            EnemyHealthChecker();
            base.Update();
        }

        private void PlayerTrack()
        {
            var enemyTransform = transform;
            var position = _playerTracked.transform.position;
            enemyTransform.position = Vector2.MoveTowards(enemyTransform.position, position,
                MovementSpeed * Time.deltaTime);
            enemyTransform.up = position - enemyTransform.position;
        }
        private void EnemyHealthChecker()
        {
            if (enemyHealth <= 0) Destroy(gameObject);
        }
    }
}
