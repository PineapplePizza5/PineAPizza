/* ***************************************************************
 * 프로그램 명 : CameraMove.cs
 * 작성자 : 이송이 (류서현, 신은지, 최세화, 최은정, 홍예지)
 * 최조 작성일 : 2019년 12월 04일
 * 최종 작성일 : 2019년 12월 13일
 * 프로그램 설명 : 선택된 NPC에 카메라를 고정 후 확대하거나,
 *                      고정을 풀고 축소한다.
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

    public void moving(int target)
    {
        if(target == 0)
        {
            trans = Cat.transform;
        }
        else if (target == 1)
        {
            trans = Mom.transform;
        }
        mainCamera.fieldOfView = 18;

        transform.position = new Vector3(trans.position.x,trans.position.y+0.4f,transform.position.z);
    }
    
    public void ResetCamera()
    {
        mainCamera.fieldOfView = 26;
        mainCamera.transform.position = new Vector3(0, 0, -14);
    }
}
