/* ***************************************************************
 * 프로그램 명 : NanIp2.cs
 * 작성자 : 류서현(이송이, 신은지, 최세화, 최은정, 홍예지)
 * 최조 작성일 : 2019년 12월 04일
 * 최종 작성일 : 2019년 12월 16일
 * 프로그램 설명 : 두 번째 동생 난입에 알맞게 창을 구성한다.
 *                 전체 흐름은 다음과 같다
 *                 네모 -> O -> 동작 검사 -> 맞으면 O, 틀리면 X
 *                 -> L -> 동작 검사 -> 맞으면 O, 틀리면 X
 * *************************************************************** */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NanIp2 : MonoBehaviour
{
    Countdown countd;
    RoundFlow roundf;
    Conversation conver;

    public GameObject mario;
    public GameObject[] nan1;
    public GameObject[] nan2;

    public GameObject oven;
    public GameObject correct;
    public GameObject wrong;
    public GameObject countText;
    Container situ;
    Ending endi;

    public void Start()
    {
        BodySourceManager.hit_count = 0;
        BodySourceManager.check = 1;

        endi = GameObject.Find("Canvas_ending").GetComponent<Ending>();
        conver = GameObject.Find("Canvas").GetComponent<Conversation>();
        countd = GameObject.Find("Canvas_count").GetComponent<Countdown>();
        roundf = GameObject.Find("Canvass").GetComponent<RoundFlow>();
        situ = GameObject.Find("Situation").GetComponent<Container>();

        conver.Awake();
        countd.currentTime = 12f;
        oven.SetActive(false);
        Invoke("Nanip2", 2);
    }

    void Nanip2()
    {
        Invoke("ShowAlphabet1", 1);
    }

    void ShowAlphabet1()
    {
        countd.enabled = true;
        countText.SetActive(true);
        for (int i = 0; i < 9; i++)
        {
            nan1[i].SetActive(true);
        }

        Invoke("DoCheck1", 1);

    }

    void DoCheck1()
    {
        if (BodySourceManager.check == 0)
        {
            countd.enabled = false;
            countText.SetActive(false);
            endi.hidden++;

            correct.SetActive(true);
            Invoke("ShowAlphabet2", 2);
        }

        else if (countd.currentTime == 0)
        {
            countd.enabled = false;
            countText.SetActive(false);
            wrong.SetActive(true);
            Invoke("ShowAlphabet2", 2);
        }

        else
        {
            Invoke("DoCheck1", 0);
        }
    }

    void ShowAlphabet2()
    {
        correct.SetActive(false);
        wrong.SetActive(false);

        countd.currentTime = 10f;
        countd.enabled = true;
        countText.SetActive(true);

        for (int i = 0; i < 9; i++)
        {
            if (nan1[i] != null)
            {
                nan1[i].SetActive(false);
            }

        }

        for (int i = 0; i < 9; i++)
        {
            nan2[i].SetActive(true);
        }

        BodySourceManager.hit_count = 0;
        BodySourceManager.check = 1;

        Invoke("DoCheck2", 1);


    }

    void DoCheck2()
    {
        if (BodySourceManager.check == 0)
        {
            countd.enabled = false;
            countText.SetActive(false);
            endi.hidden++;

            correct.SetActive(true);
            Invoke("GoNext", 2);
        }

        else if (countd.currentTime == 0)
        {
            countd.enabled = false;
            countText.SetActive(false);
            wrong.SetActive(true);
            Invoke("GoNext", 2);
        }

        else
        {
            Invoke("DoCheck2", 0);
        }
    }

    void GoNext()
    {
        correct.SetActive(false);
        wrong.SetActive(false);
        for (int i = 0; i < 9; i++)
        {
            if (nan2[i] != null)
            {
                nan2[i].SetActive(false);
            }

        }

        situ.situation = "RD3REAL";
        roundf.Start();
    }
}