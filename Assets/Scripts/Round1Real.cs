/* ***************************************************************
 * 프로그램 명 : Round1Real.cs
 * 작성자 : 최은정 (이송이, 류서현, 신은지, 최세화, 홍예지)
 * 최조 작성일 : 2019년 12월 02일
 * 최종 작성일 : 2019년 12월 07일
 * 프로그램 설명 : Round1의 실전 단계에 알맞게 창을 구성한다.
 * *************************************************************** */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round1Real : MonoBehaviour
{
    public GameObject sliced;
    public GameObject ingredient1;
    public GameObject ingredient2;
    public GameObject correct;
    public GameObject wrong;
    Container situ;

    // Start is called before the first frame update
    public void Start()
    {
        situ = GameObject.Find("Situation").GetComponent<Container>();

        Invoke("Round1real", 4);
    }

    void Round1real()
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
        //    else if(남은시간 < 0) {
        //          wrong.SetActive(true);
        //          break;
        //    }
        //}

        Invoke("ShowShape2", 2);
    }

    void ShowShape2()
    {
        correct.SetActive(false);
        wrong.SetActive(false);
        ingredient1.SetActive(false);

        ingredient2.SetActive(true);

        //while (true)
        //{
        //    if(알맞은 동작 인식) {
        //          correct.SetActive(true);
        //          break;
        //    }
        //    else if(남은시간 < 0) {
        //          wrong.SetActive(true);
        //          break;
        //    }
        //}

        Invoke("ShowSliced", 2);

    }

    void ShowSliced()
    {
        correct.SetActive(false);
        wrong.SetActive(false);

        sliced.SetActive(true);
        situ.situation = "NANIP1";
    }

}
