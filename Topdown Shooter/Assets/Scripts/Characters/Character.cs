using UnityEngine;

namespace Characters
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private float movementSpeed = 5;
        [SerializeField] private Rigidbody2D rb;

        protected float MovementSpeed
        {
            get => movementSpeed;
            set => movementSpeed = value;
        }

        protected Rigidbody2D Rb
        {
            get => rb;
            set => rb = value;
        }
        public virtual void Start()
        {
        
        }
        
        public virtual void Update()
        {
        
        }
    }
}
