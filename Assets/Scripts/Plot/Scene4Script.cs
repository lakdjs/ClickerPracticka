using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Scene4Script : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _buttonOne;
    [SerializeField] private GameObject _buttonTwo;
    [SerializeField] private GameObject _buttonThree;

    [SerializeField] private Text _textOne;
    [SerializeField] private GameObject _image;
    [SerializeField] private GameObject _image2;
    void Start()
    {
        _buttonOne.SetActive(true);
        _buttonTwo.SetActive(false);
        _buttonThree.SetActive(false);
        _image.SetActive(false);
        _image2.SetActive(false);
    }
    public void StateTwo()
    {
        _buttonOne.SetActive(false);
        _buttonTwo.SetActive(false);
        _textOne.text = "Приятно снова оказаться дома, сон – чудесное средство от всего.";
        _buttonThree.SetActive(true);
        _image?.SetActive(true);
        _image2?.SetActive(false);
    }
    public void StateThree()
    {
        _buttonOne.SetActive(false);
        _buttonThree.SetActive(false);
        _textOne.text = "На следующий день вы снова направляетесь в кондитерскую.";
        _buttonTwo.SetActive(true);
        _image?.SetActive(false);
        _image2?.SetActive(true);
    }
    public void GoToLevel()
    {
        Debug.Log("GoToLevel 2");
        SceneManager.LoadScene("SampleScene");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
