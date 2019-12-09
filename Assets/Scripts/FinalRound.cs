using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalRound : MonoBehaviour
{
    Container situ;

    public void Start()
    {
        situ = GameObject.Find("Situation").GetComponent<Container>();
    }
    
    void Update()
    {
        
    }

    //종료하면서 고양이 상태변수 END로 변경
    //이 아니라 그... 엔딩조건에 따라 다른 엔딩 불러오는 서현함수호출!
}
