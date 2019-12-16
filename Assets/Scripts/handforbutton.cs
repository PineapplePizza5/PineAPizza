using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handforbutton : MonoBehaviour
{

    public Transform HandMesh;
    // Start is called before the first frame update
    public void Update()
    {
        HandMesh.position = Vector3.Lerp(HandMesh.position, transform.position, Time.deltaTime * 15.0f);

    }

}
