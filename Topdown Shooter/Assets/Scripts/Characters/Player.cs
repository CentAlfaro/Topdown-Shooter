using UnityEngine;


namespace Characters
{
    public class Player : Character
    {
        // [SerializeField] private Camera sceneCamera;
        private Vector2 _moveDirection;
        private Vector2 _mousePosition;

        public override void Start()
        {
            base.Start();
        }

        public override void Update()
        {
            ProcessInputs();
            base.Update();
        }

        private void FixedUpdate()
        {
            Move();
        }

        protected virtual void ProcessInputs()
        {
            var horizontalInput = Input.GetAxisRaw("Horizontal");
            var verticalInput = Input.GetAxisRaw("Vertical");
            _moveDirection = new Vector2(horizontalInput, verticalInput).normalized;
            _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        private void Move()
        {
            Rb.velocity = new Vector2(_moveDirection.x * MovementSpeed, _moveDirection.y * MovementSpeed);
            var aimDirection = _mousePosition - Rb.position;
            var aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
            Rb.rotation = aimAngle;
        }
    }
}
