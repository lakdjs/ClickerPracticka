using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneloadingScript : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private string _firstName;
    [SerializeField] private string _secondName;
    [SerializeField] private string _thirdName;
    [SerializeField] private string _fourthName;
    [SerializeField] private string _fifthName;
    private void Update()
    {
        if(PlayerPrefs.GetInt("OrdersDone")==3&&PlayerPrefs.GetInt("Lvl")==0)
        {
            PlayerPrefs.SetInt("Lvl", PlayerPrefs.GetInt("Lvl") + 1);
            SceneLoadMethod(_firstName);
        }
        if (PlayerPrefs.GetInt("OrdersDone") == 6 && PlayerPrefs.GetInt("Lvl") == 1)
        {
            PlayerPrefs.SetInt("Lvl", PlayerPrefs.GetInt("Lvl") + 1);
            SceneLoadMethod(_secondName);
        }
        if (PlayerPrefs.GetInt("OrdersDone") == 9 && PlayerPrefs.GetInt("Lvl") == 2)
        {
            PlayerPrefs.SetInt("Lvl", PlayerPrefs.GetInt("Lvl") + 1);
            SceneLoadMethod(_thirdName);
        }
        if (PlayerPrefs.GetInt("OrdersDone") == 12 && PlayerPrefs.GetInt("Lvl") == 3)
        {
            PlayerPrefs.SetInt("Lvl", PlayerPrefs.GetInt("Lvl") + 1);
            SceneLoadMethod(_fourthName);
        }
        if (PlayerPrefs.GetInt("OrdersDone") == 15 && PlayerPrefs.GetInt("Lvl") == 4)
        {
            PlayerPrefs.SetInt("Lvl", PlayerPrefs.GetInt("Lvl") + 1);
            SceneLoadMethod(_fifthName);
        }
    }
    public void SceneLoadMethod(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void ExitMethod()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
