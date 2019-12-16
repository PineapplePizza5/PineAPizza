  
/* ***************************************************************
 * 프로그램 명 : DisableOnStart.cs
 * 작성자 : 신은지, 최세화 (류서현, 이송이, 최은정, 홍예지) + 오픈소스 - kinect for unity
 * 최조 작성일 : 2019년 11월 14일
 * 최종 작성일 : 2019년 12월 15일
 * 프로그램 설명 : 시작할 때 게임 오브젝트가 보이지 않도록 비활성화 하게 만든다 
 * *************************************************************** */
using UnityEngine;
using System.Collections;
using Windows.Kinect;

public class DisableOnStart : MonoBehaviour {

    // Use this for initialization
    void Start () 
    {
        gameObject.SetActive (false);
    }
}
