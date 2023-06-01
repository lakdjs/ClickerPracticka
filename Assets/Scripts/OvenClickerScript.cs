using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OvenClickerScript : MonoBehaviour
{
    private const string ClicksDone = "ClicksDone";
    [SerializeField] private Button _ovenButton;
    [SerializeField] private GameObject[] _ovensImages;
    private Orders.OrderScript _orderScript;
    private int _x;
    private int _coinsAdd;
    private int _clicksDone;
    private int _clicksQuantity;

    void Start()
    {
        for(int i = 1; i<_ovensImages.Length;i++)
        {
            _ovensImages[i].SetActive(false);
        }
        _orderScript = GetComponent<Orders.OrderScript>();
        PlayerPrefs.SetInt(ClicksDone, 0);
        _x = 1;
        _coinsAdd = 10;
        _ovenButton.onClick.AddListener(ClickerMechanik);
    }

    void Update()
    {
        _clicksDone = PlayerPrefs.GetInt(ClicksDone);
        _clicksQuantity = _orderScript.ClicksQuantity;

            if(_clicksDone <= _clicksQuantity/5)
            {
                _ovensImages[1].SetActive(true);
            }
            else if (_clicksDone <= _clicksQuantity / 4)
            {
                _ovensImages[2].SetActive(true);
            }
            else if (_clicksDone <= _clicksQuantity / 2)
            {
                _ovensImages[3].SetActive(true);
            }
            else if (_clicksDone < _clicksQuantity)
            { 
                _ovensImages[4].SetActive(true);
            }
            else if(_clicksDone==_clicksQuantity)
            {
                Debug.Log(5);
                _ovensImages[5].SetActive(true);
            }
           
    }
    private void ClickerMechanik()
    {
        if(PlayerPrefs.GetInt(ClicksDone)<_orderScript.ClicksQuantity)
        {
            PlayerPrefs.SetInt(ClicksDone, PlayerPrefs.GetInt(ClicksDone) + _x);
        }
        else
        {
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + _coinsAdd);
            _coinsAdd += 1;
        }
    } 

}
