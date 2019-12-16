using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class collideformom3 : MonoBehaviour
{


    LivingConver livemo;

    public GameObject button;
    public GameObject mario;

    public GameObject Mom;




    void OnTriggerExit2D(Collider2D collision)
    {



        livemo = GameObject.Find("Canvas").GetComponent<LivingConver>();
        print("답답허다");


        livemo.start_livingcon("MOM3");
        livemo.ButtonClicked();


        print("tnqkfd");





    }


}
