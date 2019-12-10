/* ***************************************************************
 * 프로그램 명 : Round3Real.cs
 * 작성자 : 최은정 (이송이, 류서현, 신은지, 최세화, 홍예지)
 * 최조 작성일 : 2019년 12월 10일
 * 최종 작성일 : 2019년 12월 10일
 * 프로그램 설명 : FinalRound에 알맞게 창을 구성한다.
 * *************************************************************** */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalRound : MonoBehaviour
{
    public GameObject ingredient1;
    public GameObject ingredient2;
    public GameObject sliced;

    public GameObject topping1;
    public GameObject topping2;
    public GameObject toppedPizza;

    public GameObject oven;
    public GameObject fire1;
    public GameObject fire2;
    public GameObject perfectPizza;

    public GameObject correct;
    public GameObject wrong;

    Container situ;
    Ending endi;
    int succeed1, succeed2, succeed3;   //각 라운드의 성공 여부(2일 때 성공, 0으로 초기화)

    public void Start()
    {
        situ = GameObject.Find("Situation").GetComponent<Container>();
        endi = GameObject.Find("Canvass").GetComponent<Ending>();


    }

    void Round1Shape1()
    {
        ingredient1.SetActive(true);

        //while (true)
        //{
        //    if(알맞은 동작 인식) {
        //          correct.SetActive(true);
        //          succeed1++;
        //          break;
        //    }
        //    else if(남은시간 < 0) {
        //          wrong.SetActive(true);
        //          break;
        //    }
        //}

        Invoke("Round1ShowShape2", 2);
    }

    void Round1Shape2()
    {
        correct.SetActive(false);
        wrong.SetActive(false);
        ingredient1.SetActive(false);

        ingredient2.SetActive(true);

        //while (true)
        //{
        //    if(알맞은 동작 인식) {
        //          correct.SetActive(true);
        //          succeed1++;
        //          break;
        //    }
        //    else if(남은시간 < 0) {
        //          wrong.SetActive(true);
        //          break;
        //    }
        //}

        Invoke("Round1ShowSliced", 2);
    }

    void Round1ShowSliced()
    {
        correct.SetActive(false);
        wrong.SetActive(false);

        sliced.SetActive(true);

        if (succeed1 == 2)  //두 주문 모두 성공한 경우 1라운드 성공
        {
            endi.yeah++;
        }
    }



    void Round2Shape1()
    {

    }

    void Round2Shape2()
    {

    }

    void Round2ShowTopped()
    {


        if (succeed2 == 2)  //두 주문 모두 성공한 경우 2라운드 성공
        {
            endi.yeah++;
        }

    }



    void Round3Shape1()
    {

    }

    void Round3Shape2()
    {

    }

    void Round3ShowPerfect()
    {



        if (succeed3 == 2)  //두 주문 모두 성공한 경우 3라운드 성공
        {
            endi.yeah++;
        }

        endi.Start();   //엔딩조건에 따라 다른 엔딩 불러오는 Ending.cs 호출

    }

}
