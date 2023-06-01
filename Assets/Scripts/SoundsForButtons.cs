using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundsForButtons : MonoBehaviour
{
    [SerializeField] private Button[] _allButtonsOnScene;
    private AudioSource _audioSource;
    [SerializeField] private AudioClip _clip;
    private void Start()
    {       
        for (int i = 0; i<_allButtonsOnScene.Length;i++)
        {
            _audioSource = _allButtonsOnScene[i].GetComponent<AudioSource>();
            _allButtonsOnScene[i].onClick.AddListener(ClickSound);           
        }
    }
    private void Update()
    {
    }
    public void ClickSound()
    {
        _audioSource.PlayOneShot(_clip);
    }
    
}
