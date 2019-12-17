/* ***************************************************************
 * 프로그램 명 : collide.cs
 * 작성자 : 신은지, 최세화(류서현, 이송이, 최은정, 홍예지)
 * 최조 작성일 : 2019년 12월 04일
 * 최종 작성일 : 2019년 12월 13일
 * 프로그램 설명 : 마법 구현시 사용한다. 오브젝트 객체와 파티클(키넥트로 인식한 사용자 손)이 충돌할 때, 충돌횟수를 체크하여 성공여부를 판단하고, 
 * 충돌한 오브젝트는 사라지게 한다.
 * *************************************************************** */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide : MonoBehaviour
{
    public GameObject a1;
    public GameObject mario;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (BodySourceManager.hit_count >= 8)
        {

            BodySourceManager.check = 0; // 0 = 성공 1 = 실패
        }
        BodySourceManager.hit_count++;
        Destroy(a1);
    }
}





