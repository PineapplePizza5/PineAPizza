/* ***************************************************************
 * 프로그램 명 : collideformom3.cs
 * 작성자 : 최세화(신은지, 류서현, 이송이, 최은정, 홍예지)
 * 최조 작성일 : 2019년 11월 24일
 * 최종 작성일 : 2019년 11월 25일
 * 프로그램 설명 : 거실 씬에서 어머니와 mario가 충돌했을 때 버튼이 실행되도록 하는 프로그램이다.
 * *************************************************************** */
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

        camermo.moving(1);
        livemo.start_livingcon("MOM1");

    }

}
