/* ***************************************************************
 * 프로그램 명 : InfraredSourceView.cs
 * 작성자 : 신은지, 최세화 (류서현, 이송이, 최은정, 홍예지) + 오픈소스 - kinect for unity
 * 최조 작성일 : 2019년 11월 14일
 * 최종 작성일 : 2019년 12월 15일
 * 프로그램 설명 : InfraredSourceManager를 이용, 게임 오브젝트에 컴포넌트를 부여한다.
 * *************************************************************** */
using UnityEngine;
using System.Collections;
using Windows.Kinect;

public class InfraredSourceView : MonoBehaviour 
{
    public GameObject InfraredSourceManager;
    private InfraredSourceManager _InfraredManager;
    
    void Start () 
    {
        gameObject.GetComponent<Renderer>().material.SetTextureScale("_MainTex", new Vector2(-1, 1));
    }
    
    void Update()
    {
        if (InfraredSourceManager == null)
        {
            return;
        }
        
        _InfraredManager = InfraredSourceManager.GetComponent<InfraredSourceManager>();
        if (_InfraredManager == null)
        {
            return;
        }
    
        gameObject.GetComponent<Renderer>().material.mainTexture = _InfraredManager.GetInfraredTexture();
    }
}
