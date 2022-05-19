using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject showPopupGameLevel;
    public AudioSource au_source;
    public AudioClip au_clipClick;
    public AudioClip au_clipClose;
    public static string ScenePlayerPrefs = "ScenePlay";
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
        if (au_source && au_clipClick) {
            au_source.PlayOneShot(au_clipClick);
        }
        showPopupGameLevel.SetActive(true);
    }
    public void ClosePopupGameLevel()
    {
        showPopupGameLevel.SetActive(false);
        if (au_source && au_clipClose) {
            au_source.PlayOneShot(au_clipClose);
        }
    }
    public void ChangeScene(string name)
	{
		switch (name) {
            case "Easy":
                Debug.Log("SaveEasy");
                PlayerPrefs.SetString(ScenePlayerPrefs, "SceneEasy");
                PlayerPrefs.Save();
                SceneManager.LoadScene("Easy");
                break;
            case "Medium":
                Debug.Log("SaveMedium");
                PlayerPrefs.SetString(ScenePlayerPrefs, "SceneMedium");
                PlayerPrefs.Save();
                SceneManager.LoadScene("Easy");
                break;
            case "Hard":
                Debug.Log("SaveHard");
                PlayerPrefs.SetString(ScenePlayerPrefs, "SceneHard");
                PlayerPrefs.Save();
                SceneManager.LoadScene("Easy");
                break;
        }
        if(au_source && au_clipClick) {
            au_source.PlayOneShot(au_clipClick);
		}
    }
    
}
