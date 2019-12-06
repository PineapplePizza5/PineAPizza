/* ***************************************************************
 * 프로그램 명 : Round3Prac.cs
 * 작성자 : 최은정 (이송이, 류서현, 신은지, 최세화, 홍예지)
 * 최조 작성일 : 2019년 12월 02일
 * 최종 작성일 : 2019년 12월 07일
 * 프로그램 설명 : Round3의 연습 단계에 알맞게 창을 구성한다.
 * *************************************************************** */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round3Prac : MonoBehaviour
{
    public GameObject oven;
    public GameObject fire1;
    public GameObject fire2;
    public GameObject correct;
    public GameObject wrong;
    Container situ;

    public void Start()
    {
        situ = GameObject.Find("Situation").GetComponent<Container>();

        Invoke("Round3prac", 8);

    }

    void Round3prac()
    {
        oven.SetActive(true);
        Invoke("ShowShape1", 1);
    }

    void ShowShape1()
    {
        fire1.SetActive(true);

        //while (true)
        //{
        //    if(알맞은 동작 인식) {
        //          correct.SetActive(true);
        //          break;
        //    }
        //}

        Invoke("ShowShape2", 2);
    }

    void ShowShape2()
    {
        correct.SetActive(false);
        fire1.SetActive(false);

        fire2.SetActive(true);

        //while (true)
        //{
        //    if(알맞은 동작 인식) {
        //          correct.SetActive(true);
        //          break;
        //    }
        //}

        situ.situation = "NANIP2";

    }

}