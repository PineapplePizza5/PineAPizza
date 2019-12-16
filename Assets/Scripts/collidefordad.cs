using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class collidefordad : MonoBehaviour
{

    public GameObject button;
    public GameObject mario;


 
          
    void OnTriggerExit2D(Collider2D collision)
    {

        SceneManager.LoadScene("TableScene");
        print("TL");



    }


}
