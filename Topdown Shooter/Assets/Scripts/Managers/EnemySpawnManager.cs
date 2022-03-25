using UnityEngine;
using Random = UnityEngine.Random;

namespace Managers
{
    public class EnemySpawnManager : MonoBehaviour
    {
        [SerializeField] private GameObject enemy;
        [SerializeField] private float initialSpawnTime;
        [SerializeField] private float spawnRepeatRate;

        private void Start()
        {
            InvokeRepeating(nameof(SpawnEnemy), initialSpawnTime, spawnRepeatRate);
        }

        private void SpawnEnemy()
        {
            var player = GameObject.FindGameObjectWithTag("player");
            if (player == null)
            {
                return;
            }
            var playerTransform = player.transform.position;
            var spawnY = Random.Range(-3f, 3f);
            var spawnX = Random.Range(-6f, 6f);
        
            var spawnPosition = new Vector2(spawnX, spawnY);
            while (Vector2.Distance(playerTransform, spawnPosition) <1)
            {
                 spawnY = Random.Range(-3f, 3f);
                 spawnX = Random.Range(-6f, 6f);
        
                 spawnPosition = new Vector2(spawnX, spawnY);
            }
            Instantiate(enemy, spawnPosition, Quaternion.identity);
        }
        
    }
    
}
