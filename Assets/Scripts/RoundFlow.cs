/* ***************************************************************
 * 프로그램 명 : RoundFlow.cs
 * 작성자 : 최은정 (이송이, 류서현, 신은지, 최세화, 홍예지)
 * 최조 작성일 : 2019년 12월 03일
 * 최종 작성일 : 2019년 12월 06일
 * 프로그램 설명 : 총 3개의 라운드, 2번의 동생 난입, 최종 시험의 흐름을 관리한다.
 *                 전체 흐름은 다음과 같다. RD1PRAC -> RD1REAL -> NANIP1 -> RD2PRAC -> RD2REAL -> RD3PRAC -> NANIP2 -> RD3REAL -> FINAL
 * *************************************************************** */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoundFlow : MonoBehaviour
{
    Round1Prac prac1;
    Round1Real real1;
    Round2Prac prac2;
    Round2Real real2;
    Round3Prac prac3;
    Round3Real real3;

    NanIp1 nanIp1;
    NanIp2 nanIp2;

    FinalRound final;

    Container situ;

    // Start is called before the first frame update
    public void Start()
    {
        Debug.Log("b");
        prac1 = GameObject.Find("Canvass").GetComponent<Round1Prac>();
        real1 = GameObject.Find("Canvass").GetComponent<Round1Real>();

        prac2 = GameObject.Find("Canvass").GetComponent<Round2Prac>();
        real2 = GameObject.Find("Canvass").GetComponent<Round2Real>();

        prac3 = GameObject.Find("Canvass").GetComponent<Round3Prac>();
        real3 = GameObject.Find("Canvass").GetComponent<Round3Real>();

        nanIp1 = GameObject.Find("Canvass").GetComponent<NanIp1>();
        nanIp2 = GameObject.Find("Canvass").GetComponent<NanIp2>();

        final = GameObject.Find("Canvass").GetComponent<FinalRound>();

        situ = GameObject.Find("Situation").GetComponent<Container>();

        Invoke("Wow", 1);
    }

    // Update is called once per frame
    void Wow() //라운드를 제어하는 함수
    {
        switch (situ.situation) {
          case "RD1PRAC":       //라운드 1 연습을 수행하는 스크립트 실행
            prac1.Start(); 
            break;
        
          case "RD1REAL":       //라운드 1 실습을 수행하는 스크립트 실행
          case "RD1GOOD":      
          case "RD1BAD":
            real1.Start();
            break;

          case "NANIP1":        //동생의 난입 1을 수행하는 스크립트 실행
            nanIp1.Start();
            break;
        
          case "RD2PRAC":       //라운드 2 연습을 수행하는 스크립트 실행
            prac2.Start();
            break;
        
          case "RD2REAL":
            real2.Start();
            break;

          case "RD2GOOD":
          case "RD2BAD":
            real2.GoNext();
            break;

          case "RD3PRAC":
            prac3.Start();
            break;

          case "NANIP2":
            nanIp2.Start();
            break;

            case "RD3REAL":
            real3.Start();
            break;

          case "RD3GOOD":
          case "RD3BAD":
            real2.GoNext();
            break;

            case "FINAL":
            final.Start();
            break;
        }


    }
}