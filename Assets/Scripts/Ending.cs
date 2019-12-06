using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    Container situ;
    public int yeah = 3;    //최종 시험에서 성공한 단계 수(임시로 3으로 초기화, 수정 필요!)

    // Start is called before the first frame update
    void Start()
    {
        situ = GameObject.Find("Situation").GetComponent<Container>();
        
        switch (yeah)
        {
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
        
    }

    // Update is called once per frame
    void Update()
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
}


