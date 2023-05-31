using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OrderImage : MonoBehaviour
{
    [SerializeField] private Image[] _glazeImages;
    [SerializeField] private Image[] _cakeImages;
    [SerializeField] private Image[] _decorationImages;
    [SerializeField] private TMP_Text[] _coinsAddSubText; 
    
    private Orders.OrderScript _orderScript;
    private void Start()
    {
        _orderScript = GetComponent<Orders.OrderScript>();
        for(int i = 0; i<_glazeImages.Length; i++)
        {
            _glazeImages[i].enabled = false;
            _cakeImages[i].enabled = false;
            _decorationImages[i].enabled = false;
        }
    }
    private void Update()
    {
        if(1>0)
        {
            MakingOrder();
        }
        
    }
    private void MakingOrder()
    {
        for(int i = 0; i<_glazeImages.Length;i++)
        {
            if(_orderScript.GlazeType.ToString()==_glazeImages[i].tag)
            {
                _glazeImages[i].enabled = true;
            }
            else
            {
                _glazeImages[i].enabled = false;
            }
            if (_orderScript.CakeType.ToString() == _cakeImages[i].tag)
            {
                _cakeImages[i].enabled = true;
            }
            else
            {
                _cakeImages[i].enabled = false;
            }
            if (_orderScript.DecorationType.ToString() == _decorationImages[i].tag)
            {
                _decorationImages[i].enabled = true;
            }
            else
            {
                _decorationImages[i].enabled = false;
            }
        }
        _coinsAddSubText[0].text = $"за правильно выполненный заказ получите {_orderScript.CoinsAdd} монет";
        _coinsAddSubText[1].text = $"за неправильно выполненный заказ получите минус {_orderScript.CoinsSub} монет";
    }
}
