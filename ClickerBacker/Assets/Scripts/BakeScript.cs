using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BakeScript : MonoBehaviour
{
    [SerializeField] private GameObject[] _components1;
    [SerializeField] private GameObject[] _components2;
    [SerializeField] private GameObject[] _components3;
    private GameObject[] _cake;
    public GameObject[] Cake
    {
        get { return _cake; }
    }
    [SerializeField] private Button _button;
    private bool SetBaking;
    private void Start()
    {
        _cake = new GameObject[3];
        SetBaking = false;
        _button.onClick.AddListener(Baking);
    }
    private void Update()
    {
        if (SetBaking == true)
        {
            _button.interactable = false;
        }
        if(Input.GetKey(KeyCode.W))
        {
            Debug.Log(_cake[0].name);
            Debug.Log(_cake[1].name);
            Debug.Log(_cake[2].name);
        }
    }
    public void Baking()
    {
        for(int i = 0; i< _components1.Length;i++)
        {
            if(_components1[i].activeSelf==true)
            {
                _cake[0] = _components1[i];
            }
            if (_components2[i].activeSelf == true)
            {
                _cake[1] = _components2[i];
            }
            if (_components3[i].activeSelf == true)
            {
                _cake[2] = _components3[i];
            }
        }
        SetBaking = true;
    }
}
