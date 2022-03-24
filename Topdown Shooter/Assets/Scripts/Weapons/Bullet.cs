using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                Destroy(gameObject);
                break;
        }
    }
}
