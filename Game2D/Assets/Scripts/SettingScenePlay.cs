using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingScenePlay : MonoBehaviour
{
    public GameObject showSetting;
    // Start is called before the first frame update
    void Start()
    {
        showSetting.SetActive(false);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showAllSetting(string name)
	{
        switch (name) {
            case "ShowPanel":
                showSetting.SetActive(true);
                break;
            case "Continue":
                showSetting.SetActive(false);
                break;
            case "Restart":
                SceneManager.LoadScene("Easy");
                break;
            case "Home":
                SceneManager.LoadScene("Home");
                break;

        }
    }
    
}
