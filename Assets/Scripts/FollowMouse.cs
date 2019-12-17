/* ***************************************************************
 * 프로그램 명 :FollowMouse.cs
 * 작성자 : 신은지, 최세화 (류서현, 이송이, 최은정, 홍예지)
 * 최조 작성일 : 2019년 12월 04일
 * 최종 작성일 : 2019년 12월 13일
 * 프로그램 설명 : 마우스 커서를 따라 유니티 상에서 파티클이 움직이도록 조정한다. 마법 구현시 사용한다. 
 * *************************************************************** */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowMouse : MonoBehaviour
{
    public float speed = 3.0f;
    public float distanceFromCamera = 5.0f;
    
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = distanceFromCamera;

        Vector3 mouseScreenToWorld = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector3 position = Vector3.Lerp(transform.position, mouseScreenToWorld, 1.0f - Mathf.Exp(-speed * Time.deltaTime));

        transform.position = position;
    }

    void LateUpdate()
    {

    }
}

