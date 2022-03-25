using Characters;
using UnityEngine;

namespace Weapons
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rb;
        public void OnTriggerEnter2D(Collider2D col)
        {
            switch (col.gameObject.tag)
            {
                case "barrier":
                    Destroy(gameObject);
                    break;
                case "enemy":
                    col.gameObject.GetComponent<Enemy>().enemyHealth -= 20f;
                    Destroy(gameObject);
                    break;
            }
        }
    }
}
