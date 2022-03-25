using Characters;
using Interfaces;
using UnityEngine;

namespace Weapons
{
    public class Bullet : MonoBehaviour
    {
        public void OnTriggerEnter2D(Collider2D col)
        {
            var enemyGoGameObject = col.gameObject;
            var enemyScript = enemyGoGameObject.GetComponent<IDamageable>();
            enemyScript?.Damage(20);
            Destroy(gameObject);
        }
    }
}
