using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{

    public class PlayerStats : MonoBehaviour
    {


        public float _basePlayerHP;
        public float _basePlayerEnergy;


        void Start()
        {
            _basePlayerHP = 100f;
            _basePlayerEnergy = 100f;
        }

    }

}