/* ***************************************************************
 * 프로그램 명 : collideforendbuttoninmenu.cs
 * 작성자 : 최세화(신은지, 류서현, 이송이, 최은정, 홍예지)
 * 최조 작성일 : 2019년 11월 24일
 * 최종 작성일 : 2019년 11월 25일
 * 프로그램 설명 : 메뉴 씬에서 '종료하기' 버튼과 mario가 충돌했을 때 버튼이 실행되도록 하는 프로그램이다.
 * *************************************************************** */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collideforendbuttoninmenu : MonoBehaviour
{
    public GameObject button;
    public GameObject mario;

    void OnTriggerEnter2D(Collider2D collision)
    {

        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_WEBPLAYER
                Application.OpenURL("http://google.com");
        #else
                Application.Quit();
        #endif
        
    }
    
}
