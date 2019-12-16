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
using UnityEngine.SceneManagement;

public class Round1Real : MonoBehaviour
{
    Countdown countd;
    RoundFlow roundf;


    public GameObject mario;
    public GameObject[] cut1;
    public GameObject[] cut2;

    public GameObject sliced;
    public GameObject correct;
    public GameObject wrong;
    public GameObject countText;
    Conversation conver;
    LifeControl lifecon;

    int succeed;

    Container situ;

    // Start is called before the first frame update
    public void Start()
    {
        BodySourceManager.hit_count = 0;
        BodySourceManager.check = 1;

        lifecon = GameObject.Find("Canvas_life").GetComponent<LifeControl>();
        conver = GameObject.Find("Canvas").GetComponent<Conversation>();
        countd = GameObject.Find("Canvas_count").GetComponent<Countdown>();
        roundf = GameObject.Find("Canvass").GetComponent<RoundFlow>();
        situ = GameObject.Find("Situation").GetComponent<Container>();

        if (lifecon.life == 2) { lifecon.Life1.SetActive(true);lifecon.Life2.SetActive(true); }
        else if (lifecon.life == 1) { lifecon.Life1.SetActive(false); lifecon.Life2.SetActive(true); }
        
        conver.Awake();
        countd.currentTime = 15f;
        for (int i = 0; i < 13; i++)
        {
            if (cut2[i] != null)
            {
                cut2[i].SetActive(false);
            }
        }
        correct.SetActive(false);
        
        Invoke("Round1real", 4);
    }

    void Round1real()
    {
        Invoke("ShowShape1", 1);
    }

    void ShowShape1()
    {
        countd.enabled = true;
        countText.SetActive(true);
        for (int i = 0; i < 17; i++)
        {
            cut1[i].SetActive(true);
        }

        Invoke("DoCheck1", 1);
    }

    void DoCheck1()
    {
        if (BodySourceManager.check == 0)   //성공했을 경우
        {
            countd.enabled = false;
            countText.SetActive(false);
            correct.SetActive(true);
            succeed++;
            Invoke("ShowShape2", 2);
        }

        else if (countd.currentTime == 0)   //실패했을 경우
        {
            Debug.Log("0");
            countd.enabled = false;
            Debug.Log("a");
            countText.SetActive(false);
            Debug.Log("bDDDDDDDD");
            wrong.SetActive(true);
            
            lifecon.life--;

            Debug.Log("라이프쭌다" + lifecon.life);

            if (lifecon.life == 1)
            {
                lifecon.Life1.SetActive(false);
                lifecon.Life2.SetActive(false);
                wrong.SetActive(false);
                SceneManager.LoadScene("LivingRoom");

            }
            else if (lifecon.life == 0)
            {
                lifecon.Life1.SetActive(false);
                lifecon.Life2.SetActive(false);

                lifecon.life = 2;
                SceneManager.LoadScene("Menu");
            }
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

        Invoke("DoCheck2", 1);

    }

    void DoCheck2()
    {
        Debug.Log("Docheck2 진입");
        if (BodySourceManager.check == 0)   //성공했을 경우
        {
            Debug.Log("succeed");
            countd.enabled = false;
            countText.SetActive(false);
            correct.SetActive(true);
            succeed++;
            Invoke("ShowSliced", 2);
        }

        else if (countd.currentTime == 0)   //실패했을 경우
        {
            
            countd.enabled = false;
            
            wrong.SetActive(true);
            
            lifecon.life--;

            if (lifecon.life == 1) { lifecon.Life1.SetActive(false); SceneManager.LoadScene("LivingRoom"); }
            else if (lifecon.life == 0) { lifecon.Life2.SetActive(false);SceneManager.LoadScene("Menu"); }
        }

        else
        {
            Invoke("DoCheck2", 0);
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

        if (succeed == 2)  //두 주문 모두 성공한 경우 1라운드 성공
        {
            situ.situation = "RD1GOOD";
            conver.Awake();
            //SceneManager.LoadScene("TableScene");
        }
        else
        {
            conver.Awake();
            situ.situation = "RD1BAD";
            //SceneManager.LoadScene("TableScene");
        }
        sliced.SetActive(true);
        Invoke("GoNext", 2);
    }

    public void GoNext()
    {
        for (int i = 0; i < 13; i++)
        {
            if (cut2[i] != null)
            {
                cut2[i].SetActive(false);
            }

        }

        countd.enabled = false;
        countText.SetActive(false);

        correct.SetActive(false);
        wrong.SetActive(false);        

        Invoke("Oh", 3);
    }

    void Oh()
    {
        situ.situation = "NANIP1";
        roundf.Start();
    }

}
