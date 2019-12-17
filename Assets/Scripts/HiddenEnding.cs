using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HiddenEnding : MonoBehaviour
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

        Invoke("GoMenu", 54);
    }

    void GoMenu()
    {
        situ.situation = "RD1PRAC";
        lifecon.life = 2;
        endi.hidden = 0;

        SceneManager.LoadScene("Menu");
    }
}
