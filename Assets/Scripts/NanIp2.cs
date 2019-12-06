/* ***************************************************************
 * 프로그램 명 : NanIp2.cs
 * 작성자 : 류서현(이송이, 신은지, 최세화, 최은정, 홍예지)
 * 최조 작성일 : 2019년 12월 04일
 * 최종 작성일 : 2019년 12월 04일
 * 프로그램 설명 : 두 번째 동생 난입에 알맞게 창을 구성한다.
 *                 전체 흐름은 다음과 같다
 *                 네모 -> L -> 동작 검사 -> 맞으면 O, 틀리면 X
 *                 -> V -> 동작 검사 -> 맞으면 O, 틀리면 X
 * *************************************************************** */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NanIp2 : MonoBehaviour
{
    public GameObject rectangle;
    public GameObject correct;
    public GameObject wrong;

    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Nanip2()
    {
        rectangle.SetActive(true);
        Invoke("ShowAlphabet1", 1);
    }

    void ShowAlphabet1()
    {
        //점으로 이루어진 E 보여주는 코드

        //동작 검사하는 코드
        //if(알맞게 동작) {
        //      correct.SetActive(true);
        //}
        //else {
        //      wrong.SetActive(true);
        //}

    }

    void ShowAlphabet2()
    {
        //점으로 이루어진 V 보여주는 코드

        //동작 검사하는 코드
        //if(알맞게 동작) {
        //      correct.SetActive(true);
        //}
        //else {
        //      wrong.SetActive(true);
        //}

    }

    //종료하면서 고양이 상태변수 RD3REAL으로 변경
}