using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject showPopupGameLevel;
    // Start is called before the first frame update
    void Start()
    {
        showPopupGameLevel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowPopupGameLevel()
	{
        showPopupGameLevel.SetActive(true);
    }
    public void ClosePopupGameLevel()
    {
        showPopupGameLevel.SetActive(false);
    }
    public void SceneEasy()
    {
        SceneManager.LoadScene("Easy");
    }
    public void SceneMedium()
    {
        SceneManager.LoadScene("Medium");
    }
    public void SceneHard()
    {
        SceneManager.LoadScene("Hard");
    }
}
