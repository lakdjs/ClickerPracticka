using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OvenClickerScript : MonoBehaviour
{
    private const string ClicksDone = "ClicksDone";
    [SerializeField] private Button _ovenButton;
    private Orders.OrderScript _orderScript;
    private int _x;
    private int _coinsAdd;

    void Start()
    {
        _orderScript = GetComponent<Orders.OrderScript>();
        PlayerPrefs.SetInt(ClicksDone, 0);
        _x = 1;
        _coinsAdd = 10;
        _ovenButton.onClick.AddListener(ClickerMechanik);
    }

    void Update()
    {
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
            _coinsAdd += 10;
        }
    } 
}
