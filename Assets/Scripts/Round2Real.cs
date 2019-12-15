/* ***************************************************************
 * 프로그램 명 : Round2Real.cs
 * 작성자 : 최은정 (이송이, 류서현, 신은지, 최세화, 홍예지)
 * 최조 작성일 : 2019년 12월 02일
 * 최종 작성일 : 2019년 12월 07일
 * 프로그램 설명 : Round2의 실전 단계에 알맞게 창을 구성한다.
 * *************************************************************** */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round2Real : MonoBehaviour
{
    RoundFlow roundf;

    public GameObject mario;
    public GameObject[] top1;
    public GameObject[] top2;

    public GameObject topped;
    public GameObject correct;
    public GameObject wrong;
    Container situ;

    // Start is called before the first frame update
    public void Start()
    {
        BodySourceManager.hit_count = 0;
        BodySourceManager.check = 1;

        roundf = GameObject.Find("Canvass").GetComponent<RoundFlow>();
        situ = GameObject.Find("Situation").GetComponent<Container>();
        
        correct.SetActive(false);

        Invoke("Round2real", 4);
    }

    void Round2real()
    {
        Invoke("ShowShape1", 1);
    }

    void ShowShape1()
    {
        for (int i = 0; i < 13; i++)
        {
            top1[i].SetActive(true);
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

        //else if(남은시간 < 0)
        //{
        //    wrong.SetActive(true);
        //    Invoke("ShowShape2", 2);
        //}

        else
        {
            Invoke("DoCheck1", 0);
        }
    }

    void ShowShape2()
    {
        correct.SetActive(false);
        wrong.SetActive(false);

        for (int i = 0; i < 13; i++)
        {
            if (top1[i] != null)
            {
                top1[i].SetActive(false);
            }

        }

        for (int i = 0; i < 17; i++)
        {
            top2[i].SetActive(true);
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
            Invoke("ShowTopped", 2);
        }

        //else if(남은시간 < 0)
        //{
        //    wrong.SetActive(true);
        //    Invoke("ShowShape2", 2);
        //}

        else
        {
            Invoke("DoCheck2", 0);
        }
    }

    void ShowTopped()
    {
        for (int i = 0; i < 17; i++)
        {
            if (top2[i] != null)
            {
                top2[i].SetActive(false);
            }

        }
        correct.SetActive(false);
        wrong.SetActive(false);

        topped.SetActive(true);
        situ.situation = "RD3PRAC";
        roundf.Start();
    }

}
