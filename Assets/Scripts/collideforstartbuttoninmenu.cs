﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collideforstartbuttoninmenu : MonoBehaviour
{

    public GameObject button;
    public GameObject mario;

    void OnTriggerEnter2D(Collider2D collision)
    {

        SceneManager.LoadScene("Prologue");


    }


}
