using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Scene3Script : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _buttonOne;
    [SerializeField] private GameObject _buttonTwo;

    [SerializeField]private Text _textOne;
    [SerializeField] private GameObject _image;
    void Start()
    {
        _buttonOne.SetActive(true);
        _buttonTwo.SetActive(false);
        _image.SetActive(false);
    }
    public void StateTwo()
    {
        _buttonOne.SetActive(false);
        _textOne.text = "ѕрибыв на место, оказываетс€, что матушка уже отправилась в путь, а к вам уже начали заходить первые посетители. ¬ы принимаетесь за работу.";
        _buttonTwo.SetActive(true);
        _image?.SetActive(true);
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
