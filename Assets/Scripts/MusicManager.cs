using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Toggle _toggle;
    private void Update()
    {
        VolumeManage();
    }
    public void VolumeManage()
    {      
        if(_toggle.isOn)
        {
            AudioListener.volume = _slider.value;
        }
        else
        {
            AudioListener.volume = 0;
        }
    }
}
