/* ***************************************************************
 * 프로그램 명 : Ending.cs
 * 작성자 : 류서현 (이송이, 최은정, 신은지, 최세화, 홍예지)
 * 최조 작성일 : 2019년 12월 12일
 * 최종 작성일 : 2019년 12월 15일
 * 프로그램 설명 : 최종 결과에 맞는 엔딩씬으로 바꾸어준다.
 * *************************************************************** */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    Container situ;
    public int yeah = 0;    //최종 시험에서 성공한 단계 수
    public int hidden = 0;    //최종 시험에서 성공한 단계 수

    // Start is called before the first frame update
    public void Start()
    {
        situ = GameObject.Find("Situation").GetComponent<Container>();
        
        switch (yeah)
        {
            case 0:
            case 1:
                situ.situation = "BADEND";
                break;
            case 2:
                situ.situation = "NORMALEND";
                break;
            case 3:
                situ.situation = "HAPPYEND";
                break;
            default:
                break;
            
        }

        Wow();
    }

    void Wow()
    {
        switch (situ.situation)
        {
            case "HAPPYEND":
                //HappyEnding 씬을 불러온다
                SceneManager.LoadScene("HappyEnding");  
                break;

            case "NORMALEND":
                //NormalEnding 씬을 불러온다
                SceneManager.LoadScene("NormalEnding");
                break;

            case "BADEND":
                //BadEnding 씬을 불러온다
                SceneManager.LoadScene("BadEnding");
                break;

            default:
                break;
        }
    }

    //private void Awake()
    //{
    //    DontDestroyOnLoad(gameObject);
    //}


}


