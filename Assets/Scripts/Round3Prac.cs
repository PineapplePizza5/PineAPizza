/* ***************************************************************
 * 프로그램 명 : Round3Prac.cs
 * 작성자 : 최은정 (이송이, 류서현, 신은지, 최세화, 홍예지)
 * 최조 작성일 : 2019년 12월 02일
 * 최종 작성일 : 2019년 12월 07일
 * 프로그램 설명 : Round3의 연습 단계에 알맞게 창을 구성한다.
 * 프로그램 흐름 : 도형1 출력(한번에)-> 맞을 때까지 검사 -> 맞으면 o 출력
 *             -> 도형2 출력(한번에)-> 맞을 때까지 검사 -> 맞으면 o 출력
 * *************************************************************** */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Round3Prac : MonoBehaviour
{
    RoundFlow roundf;

    public GameObject mario;
    public GameObject[] fir1;
    public GameObject[] fir2;

    public GameObject topped;
    public GameObject oven;
    public GameObject correct;
    public GameObject wrong;
    Container situ;

    public void Start()
    {
        roundf = GameObject.Find("Canvass").GetComponent<RoundFlow>();
        situ = GameObject.Find("Situation").GetComponent<Container>();

        topped.SetActive(false);
        oven.SetActive(true);
        mario.SetActive(true);
        Invoke("Round3prac", 4);

    }

    void Round3prac()
    {
        Invoke("ShowShape1", 1);
    }

    void ShowShape1()
    {
        for (int i = 0; i < 18; i++)
        {
            fir1[i].SetActive(true);
        }

        Invoke("DoCheck1", 1);
    }

    void DoCheck1()
    {
        if (BodySourceManager.check == 0)
        {
            correct.SetActive(true);
            Invoke("ShowShape2", 2);
        }
        else
        {
            Invoke("DoCheck1", 0);
        }
    }

    void ShowShape2()
    {
        correct.SetActive(false);
        for (int i = 0; i < 18; i++)
        {
            if (fir1[i] != null)
            {
                fir1[i].SetActive(false);
            }

        }

        for (int i = 0; i < 21; i++)
        {
            fir2[i].SetActive(true);
        }

        BodySourceManager.hit_count = 0;
        BodySourceManager.check = 1;

        Invoke("DoCheck2", 1);

    }

    void DoCheck2()
    {
        if (BodySourceManager.check == 0)
        {
            correct.SetActive(true);
            Invoke("GoNext", 2);
        }
        else
        {
            Invoke("DoCheck2", 0);
        }
    }

    void GoNext()
    {
        for (int i = 0; i < 21; i++)
        {
            if (fir2[i] != null)
            {
                fir2[i].SetActive(false);
            }

        }
        correct.SetActive(false);
        wrong.SetActive(false);

        situ.situation = "NANIP2";
        roundf.Start();
    }

}