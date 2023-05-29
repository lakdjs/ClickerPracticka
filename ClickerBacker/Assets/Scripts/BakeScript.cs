using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BakeScript : MonoBehaviour
{
    [SerializeField] private GameObject[] _components1;
    [SerializeField] private GameObject[] _components2;
    [SerializeField] private GameObject[] _components3;
    [SerializeField] private TimerScript _timerScript;
    public GameObject[] Cake
    {
        get; private set;
    }
    [SerializeField] public Button _button;
    public bool SetBaking;
    private void Start()
    {
        Cake = new GameObject[3];
        SetBaking = false;
        _button.onClick.AddListener(Baking);
    }
    private void Update()
    {
        if(_timerScript.TimerOnOff== false)
        {
            _button.interactable = false;
        }
        if (SetBaking == true)
        {
            _button.interactable = false;
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log(Cake[0].name);
            Debug.Log(Cake[1].name);
            Debug.Log(Cake[2].name);
        }
    }
    public void Baking()
    {
        for(int i = 0; i< _components1.Length;i++)
        {
            if(_components1[i].activeSelf==true)
            {
                Cake[0] = _components1[i];
            }
            if (_components2[i].activeSelf == true)
            {
                Cake[1] = _components2[i];
            }
            if (_components3[i].activeSelf == true)
            {
                Cake[2] = _components3[i];
            }
        }
        SetBaking = true;
    }
}
