using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class collideforno : MonoBehaviour
{


    LivingConver livemo;
    SceneController scenecon;
    CameraMove camermo;

    public GameObject button;
    public GameObject mario;

    public GameObject no;



    void OnTriggerEnter2D(Collider2D collision)
    {

        camermo = GameObject.Find("Canvas").GetComponent<CameraMove>();
        livemo = GameObject.Find("Canvas").GetComponent<LivingConver>();
        scenecon = GameObject.Find("Canvas").GetComponent<SceneController>();
        print("답답허다");


        camermo.ResetCamera();
        livemo.ButtonClicked();



        print("tnqkfd");


    }


}
