/* ***************************************************************
 * 프로그램 명 : collidefordad.cs
 * 작성자 : 최세화(신은지, 류서현, 이송이, 최은정, 홍예지)
 * 최조 작성일 : 2019년 11월 24일
 * 최종 작성일 : 2019년 11월 25일
 * 프로그램 설명 : 거실 씬에서 고양이와 mario가 충돌했을 때 버튼이 실행되도록 하는 프로그램이다.
 * *************************************************************** */
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class collideforcat : MonoBehaviour
{
    CameraMove camermo;
    LivingConver livemo;

    public GameObject button;
    public GameObject mario;
    public GameObject Cat;
    

    void OnTriggerEnter2D(Collider2D collision)
    {
        camermo = GameObject.Find("Main Camera").GetComponent<CameraMove>();
        livemo = GameObject.Find("Canvas").GetComponent<LivingConver>();

        camermo.moving(0);
        livemo.start_livingcon("CAT");

    }

}
