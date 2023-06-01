using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyingImages : MonoBehaviour
{
    [SerializeField] public Image _imageForBuying;
    [SerializeField] private Image _imageLocked;
    [SerializeField] public Button _buttonForBuying;
    [SerializeField] public GameObject _button;
     private int _price;
    private void Awake()
    {
        _price = 2200;
    }
    private void Start()
    {
         
    }
    void Update()
    {
        _buttonForBuying.onClick.AddListener(BuyingImage);
        if (Input.GetKey(KeyCode.I))
        {
            Debug.Log(PlayerPrefs.GetInt(_imageForBuying.name));
        }
        if (PlayerPrefs.GetInt(_imageForBuying.name)==0)
        {
            _imageForBuying.enabled = false;
            _imageLocked.enabled = true;
        }
        else if(PlayerPrefs.GetInt(_imageForBuying.name)>0)
        {
            _imageForBuying.enabled = true;
            _imageLocked.enabled = false;
        }
    }
    public void BuyingImage()
    {
        if(PlayerPrefs.GetInt("Coins")>=_price)
        {
            Debug.Log("Bought");
            PlayerPrefs.SetInt(_imageForBuying.name, 1);
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - _price);
        }
    }
}
