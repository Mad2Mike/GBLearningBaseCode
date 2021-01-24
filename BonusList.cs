using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace Geekbrains
{

    public class BonusList : MonoBehaviour
    {
        [SerializeField] private PlayerStats PlayerStats;
        [SerializeField] private PlayerMovementScr2 PlayerMovementScr2;
       public void HealthUp(float value)
        {
            PlayerStats._basePlayerHP =+ value;
        }
        public void SpeedUp(float delayTime, float value)
        {

            StartCoroutine(SpeedUpCor(delayTime, value)); 

        }

        public void SpeedDown(float delayTime, float value)
        {
            StartCoroutine(SpeedDownCor(delayTime, value));
        }
       

        IEnumerator SpeedUpCor(float delayTime, float value)
        {
            PlayerMovementScr2.Speed = +value;
            yield return new WaitForSeconds(delayTime);
            PlayerMovementScr2.Speed = -value;
        }
        IEnumerator SpeedDownCor(float delayTime, float value)
        {
            PlayerMovementScr2.Speed = -value;
            yield return new WaitForSeconds(delayTime);
            PlayerMovementScr2.Speed = +value;
        }




    }

   
}