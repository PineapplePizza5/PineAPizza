using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class collideforyes : MonoBehaviour
{


    LivingConver livemo;
    SceneController scenecon;

    public GameObject button;
    public GameObject mario;

    public GameObject yes;



    void OnTriggerExit2D(Collider2D collision)
    {


        livemo = GameObject.Find("Canvas").GetComponent<LivingConver>();
        scenecon = GameObject.Find("Canvas").GetComponent<SceneController>();
        print("답답허다");


        //scenecon.GameQuit();
        livemo.ButtonClicked();



        print("tnqkfd");


    }


}
