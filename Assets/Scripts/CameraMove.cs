using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class CameraMove : MonoBehaviour
//{

//    public Transform CameraTarget;
//    public float dist = 10.0f;
//    public float height = 5.0f;
//    public float dampRotate = 5.0f;
//    public float TurnSpeed;
//    public float camPos;
//    Vector3 v3;

//    private Transform tr;
//    // Start is called before the first frame update
//    void Start()
//    {
//        tr = GetComponent<Transform>();
//        TurnSpeed = 2f;
//        camPos = 2f;
//       // CatTarget = Cat.transform;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        Vector3 PositionInfo = tr.position - CameraTarget.position;
//        PositionInfo = Vector3.Normalize(PositionInfo);
//        tr.position = tr.position - (PositionInfo * Input.GetAxis("Mouse ScrollWheel") * TurnSpeed);
//    }
//}


public class CameraMove : MonoBehaviour
{
    public GameObject Cat;
    Transform CatTarget;

    public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Camera>();

        mainCamera.fieldOfView = 18;
        CatTarget = Cat.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(CatTarget.position.x,CatTarget.position.y,transform.position.z);
    }
}
