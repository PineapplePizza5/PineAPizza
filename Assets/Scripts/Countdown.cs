/* ***************************************************************
 * 프로그램 명 : Countdown.cs
 * 작성자 : 최세화 (이송이, 류서현, 신은지, 최은정, 홍예지)
 * 최조 작성일 : 2019년 12월 10일
 * 최종 작성일 : 2019년 12월 16일
 * 프로그램 설명 : 게임 라운드의 타이머를 구현하기 위한 프로그램이다.
 * *************************************************************** */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 20f;

    [SerializeField] Text countdowntext;

    public void Start()
    {
        startingTime = 20f;
        currentTime = startingTime;
    }
     
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdowntext.text = currentTime.ToString("0");

        if (currentTime >=3 && currentTime <6)
        {
            countdowntext.color = Color.yellow;
        }
        else if (currentTime < 3)
        {
            countdowntext.color = Color.red;
        }

        if (currentTime <= 0)
        {
            currentTime = 0;

        }
    }

}
