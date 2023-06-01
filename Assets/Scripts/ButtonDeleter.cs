using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDeleter : MonoBehaviour
{
    [SerializeField] private GameObject[] _image; 
    void Update()
    {
        for(int i = 0; i< _image.Length;i++)
        {    
           if (_image[i].activeInHierarchy == false)
           {
               _image[i].GetComponent<BuyingImages>()._buttonForBuying.onClick.RemoveAllListeners();
           }
            else
            {
                _image[i].GetComponent<BuyingImages>()._buttonForBuying.onClick.AddListener(_image[i].GetComponent<BuyingImages>().BuyingImage);
            }
        }
    }
}
