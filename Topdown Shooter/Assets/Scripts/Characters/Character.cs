using UnityEngine;

namespace Characters
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private CharacterData characterData;
        
        [SerializeField] private Rigidbody2D rb;

        protected CharacterData CharacterData => characterData;

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
