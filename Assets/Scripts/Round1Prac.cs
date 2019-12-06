/* ***************************************************************
 * 프로그램 명 : Round1Prac.cs
 * 작성자 : 최은정 (이송이, 류서현, 신은지, 최세화, 홍예지)
 * 최조 작성일 : 2019년 12월 02일
 * 최종 작성일 : 2019년 12월 03일
 * 프로그램 설명 : Round1의 연습 단계에 알맞게 창을 구성한다.
 * *************************************************************** */
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round1Prac : MonoBehaviour
{
    public GameObject pineApple;
    public GameObject sliced;
    public GameObject rectangle;
    public GameObject correct;
    public GameObject wrong;

    int a = 1;  //a가 1이면 동작을 첫 번째로 보여준다는 것을 의미
    
    // Start is called before the first frame update
    public void Start()
    {
        pineApple.SetActive(true);
        Invoke("Round1prac", 8);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //프로그램 흐름
    //재료 출력 -> 네모 출력 -> 도형1 출력(순서대로) -> 지우기 -> 도형2 출력(순서대로) -> 지우기
    //-> 도형1 출력(한번에)-> 맞을 때까지 검사 -> 맞으면 O 출력
    //-> 도형2 출력(한번에)-> 맞을 때까지 검사 -> 맞으면 O 출력
    //-> 완성된 재료 출력

    void Round1prac()
    {
        pineApple.SetActive(false);
        rectangle.SetActive(true);
        Invoke("ShowShape1", 2);
    }


    void ShowShape1()
    {
        //이전 모양 지우기

        if (a == 1)
        {
            a--;
            //점으로 이루어진 E를 '순서대로' 보여주는 코드
        }

        else
        {
            //점으로 이루어진 E를 '한번에' 보여주는 코드

            //알맞은 동작을 할 때까지 검사하는 반복문
            //if(동작이 맞으면){
            //      correct.SetActive(true);
            //      break;
            //}
            //else {
            //      
            //      wrong.SetActive(true);
            //}

            Invoke("ShowShape2", 2);
        }

    }

    void ShowShape2()
    {
        //이전 모양 지우기

        if (a == 1)
        {
            a--;
            //점으로 이루어진 V를 '순서대로' 보여주는 코드
            Invoke("ShowShape1", 2);
        }

        else
        {
            //점으로 이루어진 V를 '한번에' 보여주는 코드

            //알맞은 동작을 할 때까지 검사하는 반복문
            //if(동작이 맞으면){
            //      correct.SetActive(true);
            //      Invoke("ShowSliced", 2);
            //      break;
            //}
            //else {
            //      
            //      wrong.SetActive(true);
            //}
        }
        
        void ShowSliced()
        {
            sliced.SetActive(true);
        }

    }

    //종료하면서 고양이 상태변수 RD1REAL으로 변경

}