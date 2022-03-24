using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControls : MonoBehaviour
{
    [SerializeField] Camera sceneCamera;
    [SerializeField] private float movementSpeed = 5;
    [SerializeField] private Rigidbody2D rb;
    private Vector2 _moveDirection;
    private Vector2 _mousePosition;
    void Start()
    {
        
    }
    
    void Update()
    {
        ProcessInputs();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        _moveDirection = new Vector2(horizontalInput, verticalInput).normalized;
        
        _mousePosition = sceneCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    void Move()
    {
        rb.velocity = new Vector2(_moveDirection.x * movementSpeed, _moveDirection.y * movementSpeed);
        
        Vector2 aimDirection = _mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;
    }
}
