﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collideforskipbutton : MonoBehaviour
{
   

        public GameObject button;
        public GameObject mario;


        void OnTriggerExit2D(Collider2D collision)
        {
            
            SceneManager.LoadScene("Tutorial");
            print("TL");


        }
    
}
