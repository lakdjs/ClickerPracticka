using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyingImages : MonoBehaviour
{
    [SerializeField] private Image _imageForBuying;
    [SerializeField] private Image _imageLocked;
    [SerializeField] private Button _buttonForBuying;
    private void Awake()
    {
        _buttonForBuying.onClick.AddListener(BuyingImage);
    }
    private void Start()
    {
         
    }
    void Update()
    {
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
        Debug.Log("Bought");
        PlayerPrefs.SetInt(_imageForBuying.name,1);
    }
}
