﻿
using UnityEngine;



namespace Geekbrains
{
   
    public class PlayerController : MonoBehaviour
    {
    
        public float _speed = 5.0f;
        private Rigidbody _rigidbody;
        

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        protected void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            _rigidbody.AddForce(movement * _speed);
        }
    }
}
