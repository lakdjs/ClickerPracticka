using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    [SerializeField] private GameObject _buttonOne;
    [SerializeField] private GameObject _buttonTwo;
    [SerializeField] private GameObject _buttonThree;

    public GameObject[] black;

    // Start is called before the first frame update
    void Start()
    {
        _buttonOne.SetActive(true);
        _buttonTwo.SetActive(false);
        _buttonThree.SetActive(false);
        black[0].SetActive(true);
        black[1].SetActive(true);
        black[2].SetActive(false);
        black[3].SetActive(false);
        black[4].SetActive(false);
        black[5].SetActive(false);
        black[6].SetActive(false);
    }

    // Update is called once per frame
    public void StateTwo()
    {
        _buttonOne.SetActive(false);
        _buttonTwo.SetActive(true);
        _buttonThree.SetActive(false);
        black[0].SetActive(false);
        black[1].SetActive(false);
        black[2].SetActive(true);
        black[3].SetActive(true);
        black[4].SetActive(false);
        black[5].SetActive(false);
        black[6].SetActive(false);
    }

    public void StateThree()
    {
        _buttonOne.SetActive(false);
        _buttonTwo.SetActive(false);
        _buttonThree.SetActive(true);
        black[0].SetActive(false);
        black[1].SetActive(false);
        black[2].SetActive(false);
        black[3].SetActive(false);
        black[4].SetActive(true);
        black[5].SetActive(true);
        black[6].SetActive(true);
    }

    public void GoToLevel()
    {
        Debug.Log("GoToLevel 2");
        SceneManager.LoadScene("Scene3");
    }
}
