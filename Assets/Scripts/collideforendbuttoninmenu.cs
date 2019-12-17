using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collideforendbuttoninmenu : MonoBehaviour
{

    public GameObject button;
    public GameObject mario;

    void OnTriggerEnter2D(Collider2D collision)
    {

        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_WEBPLAYER
                Application.OpenURL("http://google.com");
        #else
                Application.Quit();
        #endif


    }


}
