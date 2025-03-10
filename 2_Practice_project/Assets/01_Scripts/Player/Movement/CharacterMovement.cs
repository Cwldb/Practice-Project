using System;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Action<Vector2> OnMovementPressed;

    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D _rigid;

    private Vector2 _moveVector;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    //public void Move()
    //{
    //    //_rigid.move
    //}

    //private void FixedUpdate()
    //{
    //    _rigid.linearVelocityX
    //}



}
