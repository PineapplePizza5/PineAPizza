/* ***************************************************************
 * 프로그램 명 : FinalRound.cs
 * 작성자 : 최은정 (이송이, 류서현, 신은지, 최세화, 홍예지)
 * 최조 작성일 : 2019년 12월 10일
 * 최종 작성일 : 2019년 12월 10일
 * 프로그램 설명 : FinalRound에 알맞게 창을 구성한다.
 * *************************************************************** */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalRound : MonoBehaviour
{
    Conversation conver;
    Countdown countd;
    RoundFlow roundf;

    public GameObject[] cut1;
    public GameObject[] cut2;
    public GameObject sliced;

    public GameObject[] top1;
    public GameObject[] top2;
    public GameObject topped;

    public GameObject oven;
    public GameObject[] fir1;
    public GameObject[] fir2;
    public GameObject perfect;

    public GameObject countText;
    public GameObject correct;
    public GameObject wrong;

    Container situ;
    Ending endi;
    int succeed1, succeed2, succeed3;   //각 라운드의 성공 여부(2일 때 성공, 0으로 초기화)
    LifeControl lifecon;

    public void Start()
    {
        BodySourceManager.hit_count = 0;
        BodySourceManager.check = 1;

        countd = GameObject.Find("Canvas_count").GetComponent<Countdown>();
        endi = GameObject.Find("Canvass").GetComponent<Ending>();
        roundf = GameObject.Find("Canvass").GetComponent<RoundFlow>();
        situ = GameObject.Find("Situation").GetComponent<Container>();
        conver = GameObject.Find("Canvas").GetComponent<Conversation>();
        lifecon = GameObject.Find("Canvas_life").GetComponent<LifeControl>();

        lifecon.Life1.SetActive(false); lifecon.Life2.SetActive(false);

        countd.currentTime = 10f;
        perfect.SetActive(false);
        correct.SetActive(false);
        
        conver.Awake();
        Invoke("RoundFinal", 8);
    }

    void RoundFinal()
    {
        Invoke("Round1Shape1", 1);
    }

    void Round1Shape1()
    {
        countd.enabled = true;
        countText.SetActive(true);

        for (int i = 0; i < 17; i++)
        {
            cut1[i].SetActive(true);
        }

        Invoke("DoCheck11", 1);
    }

    void DoCheck11()
    {
        if (BodySourceManager.check == 0)
        {
            countd.enabled = false;
            countText.SetActive(false);

            correct.SetActive(true);
            succeed1++;
            Invoke("Round1Shape2", 2);
        }

        else if (countd.currentTime == 0)
        {
            countd.enabled = false;
            countText.SetActive(false);
            wrong.SetActive(true);
            Invoke("Round1Shape2", 2);
        }

        else
        {
            Invoke("DoCheck11", 0);
        }
    }

    void Round1Shape2()
    {
        correct.SetActive(false);
        wrong.SetActive(false);

        countd.currentTime = 10f;
        countd.enabled = true;
        countText.SetActive(true);

        for (int i = 0; i < 17; i++)
        {
            if (cut1[i] != null)
            {
                cut1[i].SetActive(false);
            }

        }

        for (int i = 0; i < 13; i++)
        {
            cut2[i].SetActive(true);
        }

        BodySourceManager.hit_count = 0;
        BodySourceManager.check = 1;

        Invoke("DoCheck12", 1);

    }

    void DoCheck12()
    {
        if (BodySourceManager.check == 0)
        {
            countd.enabled = false;
            countText.SetActive(false);
            correct.SetActive(true);
            succeed1++;
            Invoke("ShowSliced", 2);
        }

        else if (countd.currentTime == 0)
        {
            countd.enabled = false;
            countText.SetActive(false);
            wrong.SetActive(true);
            Invoke("GoNext1", 2);
        }

        else
        {
            Invoke("DoCheck12", 0);
        }
    }

    void ShowSliced()
    {
        for (int i = 0; i < 13; i++)
        {
            if (cut2[i] != null)
            {
                cut2[i].SetActive(false);
            }

        }

        correct.SetActive(false);
        wrong.SetActive(false);

        sliced.SetActive(true);

        if (succeed1 == 2)  //두 주문 모두 성공한 경우 1라운드 성공
        {
            endi.yeah++;
        }
        Invoke("Round2Shape1", 2);
    }

    void GoNext1()
    {
        for (int i = 0; i < 13; i++)
        {
            if (cut2[i] != null)
            {
                cut2[i].SetActive(false);
            }

        }

        correct.SetActive(false);
        wrong.SetActive(false);

        Invoke("Round2Shape1", 2);
    }


    void Round2Shape1()
    {
        countd.currentTime = 10f;
        countd.enabled = true;
        countText.SetActive(true);
        sliced.SetActive(false);

        for (int i = 0; i < 13; i++)
        {
            top1[i].SetActive(true);
        }

        BodySourceManager.hit_count = 0;
        BodySourceManager.check = 1;

        Invoke("DoCheck21", 1);
    }

    void DoCheck21()
    {
        if (BodySourceManager.check == 0)
        {
            countd.enabled = false;
            countText.SetActive(false);

            correct.SetActive(true);
            succeed2++;
            Invoke("Round2Shape2", 2);
        }

        else if (countd.currentTime == 0)
        {
            countd.enabled = false;
            countText.SetActive(false);
            wrong.SetActive(true);
            Invoke("Round2Shape2", 2);
        }

        else
        {
            Invoke("DoCheck21", 0);
        }
    }

    void Round2Shape2()
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

        Invoke("DoCheck22", 1);

    }

    void DoCheck22()
    {
        if (BodySourceManager.check == 0)
        {
            countd.enabled = false;
            countText.SetActive(false);

            correct.SetActive(true);
            succeed2++;
            Invoke("ShowTopped", 2);
        }

        else if (countd.currentTime == 0)
        {
            countd.enabled = false;
            countText.SetActive(false);
            wrong.SetActive(true);
            Invoke("GoNext2", 2);
        }

        else
        {
            Invoke("DoCheck22", 0);
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

        if (succeed2 == 2)  //두 주문 모두 성공한 경우 2라운드 성공
        {
            endi.yeah++;
        }
        Invoke("Round3Shape1", 2);
    }
    
    void GoNext2()
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

        Invoke("Round3Shape1", 2);
    }



    void Round3Shape1()
    {
        countd.currentTime = 10f;
        countd.enabled = true;
        countText.SetActive(true);

        topped.SetActive(false);
        oven.SetActive(true);
        for (int i = 0; i < 18; i++)
        {
            fir1[i].SetActive(true);
        }

        BodySourceManager.hit_count = 0;
        BodySourceManager.check = 1;

        Invoke("DoCheck31", 1);
    }

    void DoCheck31()
    {
        if (BodySourceManager.check == 0)
        {
            countd.enabled = false;
            countText.SetActive(false);

            correct.SetActive(true);
            succeed3++;
            Invoke("Round3Shape2", 2);
        }

        else if (countd.currentTime == 0)
        {
            countd.enabled = false;
            countText.SetActive(false);
            wrong.SetActive(true);
            Invoke("Round3Shape2", 2);
        }

        else
        {
            Invoke("DoCheck31", 0);
        }
    }

    void Round3Shape2()
    {
        countd.currentTime = 10f;
        countd.enabled = true;
        countText.SetActive(true);

        correct.SetActive(false);
        wrong.SetActive(false);

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

        Invoke("DoCheck32", 1);

    }

    void DoCheck32()
    {
        if (BodySourceManager.check == 0)
        {
            countd.enabled = false;
            countText.SetActive(false);

            correct.SetActive(true);
            succeed3++;
            Invoke("ShowPerfect", 2);
        }

        else if (countd.currentTime == 0)
        {
            countd.enabled = false;
            countText.SetActive(false);
            wrong.SetActive(true);
            Invoke("GoNext3", 2);
        }

        else
        {
            Invoke("DoCheck32", 0);
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
        correct.SetActive(false);
        wrong.SetActive(false);

        perfect.SetActive(true);

        if (succeed3 == 2)  //두 주문 모두 성공한 경우 3라운드 성공
        {
            endi.yeah++;
        }

        endi.Start();   //엔딩조건에 따라 다른 엔딩 불러오는 Ending.cs 호출
    }

    void GoNext3()
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
        

        endi.Start();   //엔딩조건에 따라 다른 엔딩 불러오는 Ending.cs 호출
    }
}
