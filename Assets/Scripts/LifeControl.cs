/* ***************************************************************
 * 프로그램 명 : BadEnding.cs
 * 작성자 : 홍예지 (신은지, 류서현, 이송이, 최은정, 최세화)
 * 최조 작성일 : 2019년 12월 10일
 * 최종 작성일 : 2019년 12월 16일
 * 프로그램 설명 : 게임 라운드의 생명력을 제어하기 위한 프로그램이다.
 * *************************************************************** */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeControl : MonoBehaviour
{
    public int life;
    public GameObject Life1;
    public GameObject Life2;

    // Start is called before the first frame update
    void Start()
    {
        Life1.SetActive(false);
        Life2.SetActive(false);
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}