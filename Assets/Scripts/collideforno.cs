/* ***************************************************************
 * 프로그램 명 : collideforno.cs
 * 작성자 : 최세화(신은지, 류서현, 이송이, 최은정, 홍예지)
 * 최조 작성일 : 2019년 11월 24일
 * 최종 작성일 : 2019년 11월 25일
 * 프로그램 설명 : 거실 씬에서 고양이의 종료에 '아니오' 버튼과 mario가 충돌했을 때 버튼이 실행되도록 하는 프로그램이다.
 * *************************************************************** */
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
        camermo = GameObject.Find("Main Camera").GetComponent<CameraMove>();
        livemo = GameObject.Find("Canvas").GetComponent<LivingConver>();
        scenecon = GameObject.Find("Canvas").GetComponent<SceneController>();

        camermo.ResetCamera();
        livemo.ButtonClicked();

    }

}
