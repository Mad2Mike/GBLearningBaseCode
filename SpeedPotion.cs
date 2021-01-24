using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public class SpeedPotion : MonoBehaviour
    {
        [SerializeField] private BonusList BonusList;


        void OnTriggerEnter(Collider player)
        {
            if (player.gameObject.tag == "Player")
            {

                BonusList.SpeedUp(10,50);


            }
        }
    }
}
