/* ***************************************************************
 * 프로그램 명 : Container.cs
 * 작성자 : 이송이, 최은정 (류서현, 신은지, 최세화, 홍예지)
 * 최조 작성일 : 2019년 12월 04일
 * 최종 작성일 : 2019년 12월 06일
 * 프로그램 설명 : 전체 게임이 실행되는 동안 scene정보를 저장하는 
 *                    situation변수를 containe한다.
 * *************************************************************** */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    public string situation = "RD3PRAC";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
