/* ***************************************************************
 * 프로그램 명 : Round1Real.cs
 * 작성자 : 최은정 (이송이, 류서현, 신은지, 최세화, 홍예지)
 * 최조 작성일 : 2019년 12월 02일
 * 최종 작성일 : 2019년 12월 03일
 * 프로그램 설명 : Round1의 실전 단계에 알맞게 창을 구성한다.
 * *************************************************************** */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round1Real : MonoBehaviour
{
    public GameObject pineApple;
    public GameObject sliced;
    public GameObject correct;
    public GameObject wrong;

    // Start is called before the first frame update
    void Start()
    {
        if (true)   //고앵이의 상황 변수가 라운드1의 실전일 때 실행
        {
            Invoke("Round1real", 4);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void Round1real()
    {
        ShowPineApple();
    }

    void ShowPineApple()
    {
        sliced.SetActive(false);
        wrong.SetActive(false);
        pineApple.SetActive(true);

        if (true)   //'재료 손질' 동작이 알맞게 인식된 경우(수정 필요)
        {
            correct.SetActive(true);    //동그라미 표시
            Invoke("ShowSliced", 2);    //손질된 재료를 보여주는 함수 호출
        }
        else        //틀린 동작이 인식된 경우
        {
            wrong.SetActive(true);      //엑스 표시
            Invoke("ShowPineApple", 2); //ShowPineApple 재귀호출
        }
    }

    void ShowSliced()
    {
        correct.SetActive(false);
        pineApple.SetActive(false);
        sliced.SetActive(true);
    }
}
