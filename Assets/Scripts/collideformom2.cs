using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class collideformom2 : MonoBehaviour
{


    LivingConver livemo;

    public GameObject button;
    public GameObject mario;

    public GameObject Mom;


    void OnTriggerExit2D(Collider2D collision)
    {



        livemo = GameObject.Find("Canvas").GetComponent<LivingConver>();
        print("답답허다");

        
        livemo.start_livingcon("MOM2");
        livemo.ButtonClicked();


        print("tnqkfd");



    }


}
