using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public class MainCamera : MonoBehaviour
    {

        public Transform target;
        public float smooth = 5.0f;
        public Vector3 offset;


        void Start()
        {
            offset = transform.position - target.transform.position;

        }
        void Update()
        {

        }

        void LateUpdate()
        {


            transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * smooth);



        }
    }

}
