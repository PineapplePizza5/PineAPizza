﻿/* ***************************************************************
 * 프로그램 명 : Round2Prac.cs
 * 작성자 : 최은정 (이송이, 류서현, 신은지, 최세화, 홍예지)
 * 최조 작성일 : 2019년 12월 02일
 * 최종 작성일 : 2019년 12월 03일
 * 프로그램 설명 : Round2의 연습 단계에 알맞게 창을 구성한다.
 * *************************************************************** */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round2Prac : MonoBehaviour
{
    public GameObject dough;
    public GameObject toppedPizza;
    public GameObject rectangle;
    public GameObject movement1;
    public GameObject movement2;
    public GameObject correct;
    public GameObject wrong;

    int a = 1;  //a가 1이면 동작을 첫 번째로 보여준다는 것을 의미

    // Start is called before the first frame update
    void Start()
    {
        if (true)   //고앵이의 상황 변수가 라운드2의 연습일 때 실행
        {
            Invoke("Round2prac", 8);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Round2prac()
    {
        rectangle.SetActive(true);
        movement1.SetActive(false);
        movement2.SetActive(false);
        toppedPizza.SetActive(false);
        Invoke("ShowMovement1", 1);
    }

    void ShowMovement1()
    {
        movement1.SetActive(true);
        Invoke("ShowMovement2", 1);
    }

    void ShowMovement2()
    {
        movement1.SetActive(false);
        movement2.SetActive(true);

        if (a == 1)
        {
            a--;
            Invoke("Round2prac", 3);
        }
        else
        {
            Invoke("ShowDough", 2);
        }

    }

    void ShowDough()
    {
        wrong.SetActive(false);
        rectangle.SetActive(false);
        movement2.SetActive(false);
        dough.SetActive(true);

        if (true)   //'토핑 올리기' 동작이 알맞게 인식된 경우(수정 필요)
        {
            correct.SetActive(true);    //동그라미 표시
            Invoke("ShowtoppedPizza", 2);    //토핑된 피자를 보여주는 함수 호출
        }
        else        //틀린 동작이 인식된 경우
        {
            wrong.SetActive(true);      //엑스 표시
            Invoke("ShowDough", 2); //ShowDough 재귀호출
        }
    }

    void ShowtoppedPizza()
    {
        rectangle.SetActive(false);
        movement2.SetActive(false);
        dough.SetActive(false);
        correct.SetActive(false);
        toppedPizza.SetActive(true);

    }

}