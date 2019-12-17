/* ***************************************************************
 * 프로그램 명 : Round2Real.cs
 * 작성자 : 최은정 (이송이, 류서현, 신은지, 최세화, 홍예지)
 * 최조 작성일 : 2019년 12월 02일
 * 최종 작성일 : 2019년 12월 16일
 * 프로그램 설명 : Round2의 실전 단계에 알맞게 창을 구성한다.
 * *************************************************************** */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Round2Real : MonoBehaviour
{
    Countdown countd;
    RoundFlow roundf;
    Conversation conver;

    public GameObject mario;
    public GameObject[] top1;
    public GameObject[] top2;

    public GameObject topped;
    public GameObject correct;
    public GameObject wrong;
    public GameObject countText;
    Container situ;
    LifeControl lifecon;

    int succeed;

    // Start is called before the first frame update
    public void Start()
    {
        BodySourceManager.hit_count = 0;
        BodySourceManager.check = 1;

        situ = GameObject.Find("Situation").GetComponent<Container>();
        conver = GameObject.Find("Canvas").GetComponent<Conversation>();
        countd = GameObject.Find("Canvas_count").GetComponent<Countdown>();
        roundf = GameObject.Find("Canvass").GetComponent<RoundFlow>();
        lifecon = GameObject.Find("Canvas_life").GetComponent<LifeControl>();

        if (lifecon.life == 2) { lifecon.Life1.SetActive(true); lifecon.Life2.SetActive(true); }
        else if (lifecon.life == 1) { lifecon.Life1.SetActive(false); lifecon.Life2.SetActive(true); }

        conver.Awake();
        countd.currentTime = 10f;
        correct.SetActive(false);

        Invoke("Round2real", 5);
    }

    void Round2real()
    {
        Invoke("ShowShape1", 1);
    }

    void ShowShape1()
    {
        countd.enabled = true;
        countText.SetActive(true);
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
            countd.enabled = false;
            countText.SetActive(false);
            correct.SetActive(true);
            succeed++;
            Invoke("ShowShape2", 2);
        }

        else if (countd.currentTime == 0)
        {
            countd.enabled = false;
            countText.SetActive(false);
            wrong.SetActive(true);
            Invoke("ShowShape2", 2);


            lifecon.life--;
            if (lifecon.life == 1)
            { lifecon.Life1.SetActive(false); lifecon.Life2.SetActive(false); situ.situation = "RD2REAL"; SceneManager.LoadScene("LivingRoom"); }
            else if (lifecon.life == 0)
            { lifecon.Life1.SetActive(false); lifecon.Life2.SetActive(false); situ.situation = "RD2REAL"; SceneManager.LoadScene("Menu"); }
            
        }

        else
        {
            Invoke("DoCheck1", 0);
        }
    }

    void ShowShape2()
    {
        correct.SetActive(false);
        wrong.SetActive(false);

        countd.currentTime = 10f;
        countd.enabled = true;
        countText.SetActive(true);

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
            countd.enabled = false;
            countText.SetActive(false);
            correct.SetActive(true);
            succeed++;
            Invoke("ShowTopped", 2);
        }

        else if (countd.currentTime == 0)
        {
            countd.enabled = false;
            countText.SetActive(false);
            wrong.SetActive(true);
            Invoke("GoNext", 2);


            lifecon.life--;

            if (lifecon.life == 1)
            { lifecon.Life1.SetActive(false); lifecon.Life2.SetActive(false); situ.situation = "RD2REAL"; SceneManager.LoadScene("LivingRoom"); }

            else if (lifecon.life == 0)
            { lifecon.Life1.SetActive(false); lifecon.Life2.SetActive(false); situ.situation = "RD2REAL"; SceneManager.LoadScene("Menu"); }
            
        }

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
        
        if (succeed == 2)  //두 주문 모두 성공한 경우 2라운드 성공
        {
            situ.situation = "RD2GOOD";
            conver.Awake();
        }
        else
        {
            situ.situation = "RD2BAD";
            conver.Awake();
        }

        topped.SetActive(true);
        Invoke("GoNext", 2);
    }

    public void GoNext()
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

        situ.situation = "RD3PRAC";
        roundf.Start();
    }

}