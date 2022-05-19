using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayController : MonoBehaviour
{
    // Start is called before the first frame update
    //GameController g_c;
    public Text textPlayer;
    void Start()
    {
        //g_c = gameObject.FindObjectOfType<GameController>();
        string scene = PlayerPrefs.GetString(GameController.ScenePlayerPrefs);
        textPlayer.text = scene;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
