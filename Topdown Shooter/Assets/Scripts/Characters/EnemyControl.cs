using UnityEngine;

namespace Characters
{
    public class EnemyControl : Character
    {
        private GameObject _playerTracked;
        
        public override void Start()
        {
            _playerTracked = GameObject.FindGameObjectWithTag("player");
        }
        
        public override void Update()
        {
            PlayerTrack();
        }

        private void PlayerTrack()
        {
            var enemyTransform = transform;
            var position = _playerTracked.transform.position;
            enemyTransform.position = Vector2.MoveTowards(enemyTransform.position, position,
                MovementSpeed * Time.deltaTime);
            enemyTransform.up = position - enemyTransform.position;
        }
    }
}
