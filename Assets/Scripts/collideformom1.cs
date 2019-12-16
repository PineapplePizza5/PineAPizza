using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class collideformom1 : MonoBehaviour
{

    CameraMove camermo;
    LivingConver livemo;

    public GameObject button;
    public GameObject mario;

    public GameObject Mom;



    void OnTriggerEnter2D(Collider2D collision)
    {
       
        camermo = GameObject.Find("Canvas").GetComponent<CameraMove>();
        livemo = GameObject.Find("Canvas").GetComponent<LivingConver>();
        print("답답허다");

        camermo.moving(1);
        livemo.start_livingcon("MOM1");


        print("tnqkfd");



    }
      

}
