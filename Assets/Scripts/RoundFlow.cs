﻿/* ***************************************************************
 * 프로그램 명 : RoundFlow.cs
 * 작성자 : 최은정 (이송이, 류서현, 신은지, 최세화, 홍예지)
 * 최조 작성일 : 2019년 12월 03일
 * 최종 작성일 : 2019년 12월 04일
 * 프로그램 설명 : 총 3개의 라운드, 2번의 동생 난입, 최종 시험의 흐름을 관리한다.
 * *************************************************************** */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RoundFlow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Round1Prac prac1 = GameObject.Find("Canvass").GetComponent<Round1Prac>();
        Round1Real real1 = GameObject.Find("Canvass").GetComponent<Round1Real>();

        Round2Prac prac2 = GameObject.Find("Canvass").GetComponent<Round2Prac>();
        Round2Real real2 = GameObject.Find("Canvass").GetComponent<Round2Real>();

        Round3Prac prac3 = GameObject.Find("Canvass").GetComponent<Round3Prac>();
        Round3Real real3 = GameObject.Find("Canvass").GetComponent<Round3Real>();

    }

    // Update is called once per frame
    void Update()                           //수정 필요
    {
        //switch(고양이 상황변수) {
        //  case RD1PREC:
        //      prac1.Start();
        //      break;
        //
        //  case RD1REAL:
        //      real1.Start();
        //      break;
        //
        //  case RD2PREC:
        //      prac2.Start();
        //      break;
        //
        //  case RD2REAL:
        //      real2.Start();
        //      break;
        //
        //  case RD3PREC:
        //      prac3.Start();
        //      break;
        //
        //  case RD3REAL:
        //      real3.Start();
        //      break;
        //
        //  case NANIP1:
        //      
        //      break;
        //
        //  case NANIP2:
        //      
        //      break;
        //
        //  case FINAL:
        //      
        //      break;
        //
        //  default:
        //      break;
        //}


    }
}