/* ***************************************************************
 * 프로그램 명 : Round1Prac.cs
 * 작성자 : 최은정 (이송이, 류서현, 신은지, 최세화, 홍예지)
 * 최조 작성일 : 2019년 12월 02일
 * 최종 작성일 : 2019년 12월 07일
 * 프로그램 설명 : Round1의 연습 단계에 알맞게 창을 구성한다.
 * 프로그램 흐름 : 도형1 출력(한번에)-> 맞을 때까지 검사 -> 맞으면 o 출력
 *             -> 도형2 출력(한번에)-> 맞을 때까지 검사 -> 맞으면 o 출력
 * *************************************************************** */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round1Prac : MonoBehaviour
{
    public GameObject ingredient1;
    public GameObject ingredient2;
    public GameObject correct;
    public GameObject wrong;
    Container situ;
    
    public void Start()
    {
        situ = GameObject.Find("Situation").GetComponent<Container>();
        
        Invoke("Round1prac", 8);
        
    }

    void Round1prac()
    {
        Invoke("ShowShape1", 1);
    }

    void ShowShape1()
    {
        ingredient1.SetActive(true);

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
        ingredient1.SetActive(false);
        
        ingredient2.SetActive(true);

        //while (true)
        //{
        //    if(알맞은 동작 인식) {
        //          correct.SetActive(true);
        //          break;
        //    }
        //}

        situ.situation = "RD1REAL";

    }

}