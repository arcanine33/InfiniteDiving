using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {


    public static Restart instance = null;
           
    void Awake()
    {
        instance = this;
    }
    


    public void onRestart(){
        //Time.timeScale = 1.0f;
        GameMgr.instance.isGameOver = false;
        SceneManager.LoadScene("Play");
    }
}
