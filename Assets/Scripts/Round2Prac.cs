/* ***************************************************************
 * 프로그램 명 : Round2Prac.cs
 * 작성자 : 최은정 (이송이, 류서현, 신은지, 최세화, 홍예지)
 * 최조 작성일 : 2019년 12월 02일
 * 최종 작성일 : 2019년 12월 07일
 * 프로그램 설명 : Round2의 연습 단계에 알맞게 창을 구성한다.
 * *************************************************************** */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round2Prac : MonoBehaviour
{
    public GameObject topping1;
    public GameObject topping2;
    public GameObject correct;
    public GameObject wrong;
    Container situ;

    public void Start()
    {
        situ = GameObject.Find("Situation").GetComponent<Container>();

        Invoke("Round2prac", 8);

    }

    void Round2prac()
    {
        Invoke("ShowShape1", 1);
    }

    void ShowShape1()
    {
        topping1.SetActive(true);

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
        topping1.SetActive(false);

        topping2.SetActive(true);

        //while (true)
        //{
        //    if(알맞은 동작 인식) {
        //          correct.SetActive(true);
        //          break;
        //    }
        //}

        situ.situation = "RD2REAL";

    }

}