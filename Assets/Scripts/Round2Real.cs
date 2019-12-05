/* ***************************************************************
 * 프로그램 명 : Round2Real.cs
 * 작성자 : 최은정 (이송이, 류서현, 신은지, 최세화, 홍예지)
 * 최조 작성일 : 2019년 12월 02일
 * 최종 작성일 : 2019년 12월 03일
 * 프로그램 설명 : Round2의 실전 단계에 알맞게 창을 구성한다.
 * *************************************************************** */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round2Real : MonoBehaviour
{
    public GameObject dough;
    public GameObject toppedPizza;
    public GameObject correct;
    public GameObject wrong;

    // Start is called before the first frame update
    public void Start()
    {
        if (true)   //고앵이의 상황 변수가 라운드2의 실전일 때 실행
        {
            Invoke("Round2real", 6);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Round2real()
    {
        ShowDough();
    }

    void ShowDough()
    {
        toppedPizza.SetActive(false);
        wrong.SetActive(false);
        dough.SetActive(true);

        if (true)   //'토핑 올리기' 동작이 알맞게 인식된 경우(수정 필요)
        {
            correct.SetActive(true);    //동그라미 표시
            Invoke("ShowTopped", 2);    //토핑된 피자를 보여주는 함수 호출
        }
        else        //틀린 동작이 인식된 경우
        {
            wrong.SetActive(true);      //엑스 표시
            Invoke("ShowDough", 2);     //ShowDough 재귀호출
        }
    }

    void ShowTopped()
    {
        correct.SetActive(false);
        dough.SetActive(false);
        toppedPizza.SetActive(true);
    }

    //종료하면서 고양이 상태변수 RD3PRAC으로 변경
}
