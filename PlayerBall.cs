using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public class PlayerBall : PlayerController
    {
        // Start is called before the first frame update


        // Update is called once per frame
        void FixedUpdate()
        {
            Move();
        }
    }
}
