﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScr2 : MonoBehaviour
{
   
    // т.к. логика движения изменилась мы выставили меньшее и более стандартное значение
    public float Speed = 20f;

    public float JumpForce = 50f;

    //что бы эта переменная работала добавьте тэг "Ground" на вашу поверхность земли
    private bool _isGrounded;
    private Rigidbody _rb;
    Quaternion m_Rotation = Quaternion.identity;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        //обратите внимание что все действия с физикой 
        //желательно делать в FixedUpdate, а не в Update
        JumpLogic();

        // в даном случае допустимо использовать это здесь, но можно и в Update.
        // но раз уж вызываем здесь, то 
        // двигать будем используя множитель fixedDeltaTimе 
        MovementLogic();
    }

    public void MovementLogic()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        

        transform.Translate(movement * Speed * Time.fixedDeltaTime);
       
    }

    public void JumpLogic()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            if (_isGrounded)
            {
                // Обратите внимание что я делаю на основе Vector3.up а не на основе transform.up
                // если наш персонаж это шар -- его up может быть в том числе и вниз и влево и вправо. 
                // Но нам нужен скачек только вверх! Потому и Vector3.up
                _rb.AddForce(Vector3.up * JumpForce);
            }
        }
    }
   
    void OnCollisionEnter(Collision collision)
    {
        IsGroundedUpate(collision, true);
    }

    void OnCollisionExit(Collision collision)
    {
        IsGroundedUpate(collision, false);
    }

    private void IsGroundedUpate(Collision collision, bool value)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            _isGrounded = value;
        }
    }
}
