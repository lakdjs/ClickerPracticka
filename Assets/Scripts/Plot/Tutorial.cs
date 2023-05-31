using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    [SerializeField] private GameObject _buttonOne;
    [SerializeField] private GameObject _buttonTwo;
    [SerializeField] private GameObject _buttonThree;
    // Start is called before the first frame update
    void Start()
    {
        _buttonOne.SetActive(true);
        _buttonTwo.SetActive(false);
        _buttonThree.SetActive(false);
    }

    // Update is called once per frame
    public void StateTwo()
    {
        _buttonOne.SetActive(false);
        _buttonTwo.SetActive(true);
        _buttonThree.SetActive(false);
    }

    public void StateThree()
    {
        _buttonOne.SetActive(false);
        _buttonTwo.SetActive(false);
        _buttonThree.SetActive(true);
    }

    public void GoToLevel()
    {
        Debug.Log("GoToLevel 2");
        SceneManager.LoadScene("Scene3");
    }
}
