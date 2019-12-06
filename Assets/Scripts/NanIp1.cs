/* ***************************************************************
 * 프로그램 명 : NanIp1.cs
 * 작성자 : 류서현(이송이, 신은지, 최세화, 최은정, 홍예지)
 * 최조 작성일 : 2019년 12월 04일
 * 최종 작성일 : 2019년 12월 07일
 * 프로그램 설명 : 첫 번째 동생 난입에 알맞게 창을 구성한다.
 *                 전체 흐름은 다음과 같다
 *                 네모 -> E -> 동작 검사 -> 맞으면 O, 틀리면 X
 *                 -> O -> 동작 검사 -> 맞으면 O, 틀리면 X
 * *************************************************************** */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NanIp1 : MonoBehaviour
{
    public GameObject correct;
    public GameObject wrong;
    Container situ;
    
    public void Start()
    {
        situ = GameObject.Find("Situation").GetComponent<Container>();

        Invoke("Nanip2", 4);
    }

    void Nanip2()
    {
        Invoke("ShowAlphabet1", 1);
    }

    void ShowAlphabet1()
    {
        //점으로 이루어진 E 보여주는 코드

        //while(true) {
        //      if(알맞게 동작 인식) {
        //          correct.SetActive(true);
        //          break;
        //      }
        //      else {
        //          wrong.SetActive(true);
        //          break;
        //      }
        //}

        Invoke("ShowAlphabet2", 2);

    }

    void ShowAlphabet2()
    {
        //점으로 이루어진 O 보여주는 코드

        //while(true) {
        //      if(알맞게 동작 인식) {
        //          correct.SetActive(true);
        //          break;
        //      }
        //      else {
        //          wrong.SetActive(true);
        //          break;
        //      }
        //}

        situ.situation = "RD2PRAC";
    }

}