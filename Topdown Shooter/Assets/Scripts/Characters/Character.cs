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
        // Start is called before the first frame update
        public virtual void Start()
        {
        
        }

        // Update is called once per frame
        public virtual void Update()
        {
        
        }
    }
}
