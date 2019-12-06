/* ***************************************************************
 * 프로그램 명 : CameraMove.cs
 * 작성자 : 이송이 (류서현, 신은지, 최세화, 최은정, 홍예지)
 * 최조 작성일 : 2019년 12월 04일
 * 최종 작성일 : 2019년 12월 06일
 * 프로그램 설명 : 선택된 NPC에 카메라 고정 후 확대
 * *************************************************************** */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject Cat;
    public GameObject Mom;
    Transform trans;

    public Camera mainCamera;
    // Start is called before the first frame update
    public void Start()
    {
    }

    public void moving(int target)
    {
        //mainCamera = GetComponent<Camera>();
        if(target == 0)
        {
            trans = Cat.transform;
        }
        else if (target == 1)
        {
            trans = Mom.transform;
        }
        mainCamera.fieldOfView = 18;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(trans.position.x,trans.position.y,transform.position.z);
    }
    
}
