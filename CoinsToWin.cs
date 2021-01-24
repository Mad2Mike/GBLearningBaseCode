using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{

    public class CoinsToWin : MonoBehaviour
    {

        [SerializeField] private int _coinsToWin;

        private void Start()
        {
            _coinsToWin = 3;
        }
        public void OnTriggerEnter(Collider coins)
        {
            if (coins.gameObject.tag == "CoinsToWin")
            {

                _coinsToWin--;
                CoinsCheck();
                Destroy(coins.gameObject);


            }
        }

        private void CoinsCheck()
        {
            if (_coinsToWin > 0)
                Debug.Log(_coinsToWin);
            if (_coinsToWin == 0)
                print("Win");
        }



    }
}