using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComponentsButton : MonoBehaviour
{
    [SerializeField] private Button _buttonRight;
    [SerializeField] private Button _buttonLeft;
    [SerializeField] private GameObject[] _images;
    [SerializeField] private TimerScript _timerScript;   
    private int _index;
    private void Start()
    {
       for(int i = 1; i<_images.Length;i++)
        {
            _images[i].SetActive(false);
        }
        _images[0].SetActive(true);
    }
    private void Update()
    {
        if(_timerScript.TimerOnOff == false)
        {
            _buttonLeft.interactable = false;
            _buttonRight.interactable = false;
        }
    }
    private void Awake()
    {
        _buttonRight.onClick.AddListener(EternalMoveRight);
        _buttonLeft.onClick.AddListener(EternalMoveLeft);
    }

    public void EternalMoveRight()
    {
        if (_index == _images.Length - 1)
        {
            _index = 0;
            _images[_index].SetActive(true);
            _images[_images.Length - 1].SetActive(false);
        }

        else
        {
            _index++;
            _images[_index].SetActive(true);
            _images[_index - 1].SetActive(false);
        }
    }
    public void EternalMoveLeft()
    {
        if (_index == 0)
        {
            _index= _images.Length - 1;
            _images[_index].SetActive(true);
            _images[0].SetActive(false);
        }

        else
        {
            _index--;
            _images[_index].SetActive(true);
            _images[_index + 1].SetActive(false);
        }
    }
}

