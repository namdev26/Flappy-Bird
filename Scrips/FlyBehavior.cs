using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class FlyBehavior : NamMonoBehaviour
{
    [SerializeField] private float _velocity = 1.5f;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _rotationSpeed = 10f;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadRigidBody2D();
    }
    private void LoadRigidBody2D()
    {
        if (this._rb != null) return;
        this._rb = this.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        this.Move();
    }
    private void FixedUpdate()
    {
        this.Rotate();
    }
    private void Move()
    {
        // if (Touchscreen.current.)
        // {
        //     _rb.velocity = Vector2.up * _velocity;
        // }
        if (Input.touchCount > 0)
        {
            _rb.velocity = Vector2.up * _velocity;
        }
    }
    private void Rotate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _rotationSpeed);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        GameManager.instance.GameOver();
    }
}
