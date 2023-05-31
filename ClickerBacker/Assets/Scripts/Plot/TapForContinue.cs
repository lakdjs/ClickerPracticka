using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapForContinue : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _adviseText;
    void Start()
    {
        _adviseText.SetActive(false);
        InvokeRepeating("advise", 8, 0);
    }
    void advise()
    {
        _adviseText.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
