using Achievements;
using UnityEngine;


namespace Characters
{
    public class Player : Character
    {
        private Vector2 _moveDirection;
        private Vector2 _mousePosition;
        
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
            if (Camera.main != null)
            {
                _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
            if (horizontalInput != 0 || verticalInput != 0)
            {
                AchievementsManager.Instance.UpdateAchievements(AchievementTypes.ButtonPress, 1);
            }
        }

        private void Move()
        {
            Rb.velocity = new Vector2(_moveDirection.x * CharacterData.movementSpeed, _moveDirection.y * CharacterData.movementSpeed);
            var aimDirection = _mousePosition - Rb.position;
            var aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
            Rb.rotation = aimAngle;
        }
    }
}
