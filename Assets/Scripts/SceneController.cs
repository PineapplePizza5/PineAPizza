/* ***************************************************************
 * 프로그램 명 : SceneController.cs
 * 작성자 : 최은정, 홍예지 (이송이, 류서현, 신은지, 최세화)
 * 최조 작성일 : 2019년 11월 21일
 * 최종 작성일 : 2019년 11월 22일
 * 프로그램 설명 : 씬의 이름이나 번호를 통해 다음 씬을 로드한다.
 * *************************************************************** */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour { 
    
    public void SceneLoad(string sceneName) {   //씬 이름(문자열)을 통해 씬을 로드
        SceneManager.LoadScene(sceneName);
    }
    public void SceneLoad(int sceneNum) {       //씬 번호(숫자)를 통해 씬을 로드
        SceneManager.LoadScene(sceneNum);
    }
    
    public void GameQuit()
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
