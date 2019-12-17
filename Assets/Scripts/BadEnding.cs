/* ***************************************************************
 * 프로그램 명 : BadEnding.cs
 * 작성자 : 류서현, 최은정, 최세화, 홍예지 (이송이, 신은지)
 * 최조 작성일 : 2019년 12월 10일
 * 최종 작성일 : 2019년 12월 16일
 * 프로그램 설명 : 배드 엔딩을 보여준 다음 씬 전환에 필요한 프로그램이다.
 * *************************************************************** */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BadEnding : MonoBehaviour
{
    LifeControl lifecon;
    Container situ;
    Ending endi;
    
    void Start()
    {
        situ = GameObject.Find("Situation").GetComponent<Container>();
        lifecon = GameObject.Find("Canvas_life").GetComponent<LifeControl>();
        endi = GameObject.Find("Canvas_ending").GetComponent<Ending>();

        if (endi.hidden == 4)
        {
            Invoke("ShowHidden", 15);
        }
        else
        {
            Invoke("GoMenu", 15);
        }
    }

    void ShowHidden()
    {
        SceneManager.LoadScene("HiddenEnding");
    }

    void GoMenu()
    {
        situ.situation = "RD1PRAC";
        lifecon.life = 2;
        endi.hidden = 0;

        SceneManager.LoadScene("Menu");
    }

}
