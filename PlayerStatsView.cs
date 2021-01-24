using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Geekbrains
{

    public class PlayerStatsView : MonoBehaviour
    {

        [SerializeField] private Slider _playerHPSlider;
        [SerializeField] private Slider _playerEnergySlider;
        [SerializeField] private PlayerStats PlayerStats;
        

        // Start is called before the first frame update
     

        // Update is called once per frame
        void Update()
        {
            _playerHPSlider.maxValue = PlayerStats._basePlayerHP;
            _playerEnergySlider.maxValue = PlayerStats._basePlayerEnergy;
            _playerHPSlider.value = PlayerStats._basePlayerHP;
            _playerEnergySlider.value = PlayerStats._basePlayerEnergy;
        }
    }
}