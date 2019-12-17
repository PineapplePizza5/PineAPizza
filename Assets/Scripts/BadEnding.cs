using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BadEnding : MonoBehaviour
{
    LifeControl lifecon;
    Container situ;
    Ending endi;

    // Start is called before the first frame update
    void Start()
    {
        situ = GameObject.Find("Situation").GetComponent<Container>();
        lifecon = GameObject.Find("Canvas_life").GetComponent<LifeControl>();
        endi = GameObject.Find("Canvass").GetComponent<Ending>();

        if (endi.hidden == 4)
        {
            Invoke("ShowHidden", 15);
        }
        else
        {
            Invoke("GoMenu", 15);
        }
    }

    void ShowHidden()
    {
        SceneManager.LoadScene("HiddenEnding");
    }

    void GoMenu()
    {
        situ.situation = "RD1PRAC";
        lifecon.life = 2;
        endi.hidden = 0;

        SceneManager.LoadScene("Menu");
    }

}
