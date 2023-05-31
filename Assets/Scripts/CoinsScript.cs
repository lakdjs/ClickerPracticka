using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsScript : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    void Update()
    {
        CoinsDebug();
    }
    private void CoinsDebug()
    {
        _text.text = $"coins:{PlayerPrefs.GetInt("Coins")}";
    }
}
