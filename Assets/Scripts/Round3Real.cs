/* ***************************************************************
 * 프로그램 명 : Round3Real.cs
 * 작성자 : 최은정 (이송이, 류서현, 신은지, 최세화, 홍예지)
 * 최조 작성일 : 2019년 12월 02일
 * 최종 작성일 : 2019년 12월 16일
 * 프로그램 설명 : Round3의 실전 단계에 알맞게 창을 구성한다.
 * *************************************************************** */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Round3Real : MonoBehaviour
{
    Conversation conver;
    Countdown countd;
    RoundFlow roundf;

    public GameObject mario;
    public GameObject[] fir1;
    public GameObject[] fir2;

    public GameObject perfect;
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

        countd = GameObject.Find("Canvas_count").GetComponent<Countdown>();
        roundf = GameObject.Find("Canvass").GetComponent<RoundFlow>();
        situ = GameObject.Find("Situation").GetComponent<Container>();
        conver = GameObject.Find("Canvas").GetComponent<Conversation>();
        lifecon = GameObject.Find("Canvas_life").GetComponent<LifeControl>();

        if (lifecon.life == 2) { lifecon.Life1.SetActive(true); lifecon.Life2.SetActive(true); }
        else if (lifecon.life == 1) { lifecon.Life1.SetActive(false); lifecon.Life2.SetActive(true); }

        conver.Awake();
        countd.currentTime = 10f;
        correct.SetActive(false);

        Invoke("Round3real", 2);
    }

    void Round3real()
    {
        Invoke("ShowShape1", 1);
    }

    void ShowShape1()
    {
        countd.enabled = true;
        countText.SetActive(true);

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
            countd.enabled = false;
            countText.SetActive(false);
            succeed++;

            correct.SetActive(true);
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
            { lifecon.Life1.SetActive(false); lifecon.Life2.SetActive(false); situ.situation = "RD3REAL"; SceneManager.LoadScene("LivingRoom"); }

            else if (lifecon.life == 0)
            { lifecon.Life1.SetActive(false); lifecon.Life2.SetActive(false); situ.situation = "RD3REAL"; SceneManager.LoadScene("Menu"); }
            
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
            countd.enabled = false;
            countText.SetActive(false);
            succeed++;

            correct.SetActive(true);
            Invoke("ShowPerfect", 2);
        }

        else if (countd.currentTime == 0)
        {
            countd.enabled = false;
            countText.SetActive(false);
            wrong.SetActive(true);
            Invoke("GoNext", 2);


            lifecon.life--;

            if (lifecon.life == 1)
            { lifecon.Life1.SetActive(false); lifecon.Life2.SetActive(false); situ.situation = "RD3REAL"; SceneManager.LoadScene("LivingRoom"); }

            else if (lifecon.life == 0)
            { lifecon.Life1.SetActive(false); lifecon.Life2.SetActive(false); situ.situation = "RD3REAL"; SceneManager.LoadScene("Menu"); }
            
        }

        else
        {
            Invoke("DoCheck2", 0);
        }
    }

    void ShowPerfect()
    {
        for (int i = 0; i < 21; i++)
        {
            if (fir2[i] != null)
            {
                fir2[i].SetActive(false);
            }

        }

        if (succeed == 2)  //두 주문 모두 성공한 경우 3라운드 성공
        {
            situ.situation = "RD3GOOD";
            conver.Awake();
        }
        else
        {
            situ.situation = "RD3BAD";
            conver.Awake();
        }

        perfect.SetActive(true);

        correct.SetActive(false);
        wrong.SetActive(false);

        situ.situation = "FINAL";
        roundf.Start();
    }

    public void GoNext()
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

        Invoke("Oh", 3);
        
    }
    
    void Oh()
    {
        situ.situation = "FINAL";
        roundf.Start();
    }

}
