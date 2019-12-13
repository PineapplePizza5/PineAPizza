using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide : MonoBehaviour
{
    public GameObject a1;
    public GameObject mario;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (BodySourceManager.hit_count == 10)
        {
            BodySourceManager.check = 0; // check가 0이면 성공한 것, 0 아니면 실패한것. BodySourceManager.cs에 들어있는 전역변수입니다
        }
        BodySourceManager.hit_count++;
        print("충돌");
        Destroy(a1);


    }

}



//public class collision : MonoBehaviour
//{
   

//    void Start()
//    {
//        //string b = "a";
//        //string c;
//        //flame = GetComponent<ParticleSystem>();
//        //collisionEvents = new List<ParticleCollisionEvent>();
//        //for(int i=0; i<13; i++)
//        //{
//        //    c = b + i+1.ToString();
//        //    a[i].name = c;
//        //    c = null;
//        //}
//    }



//    void OnParticleCollision(GameObject other)
//    {
//        //if (other.gameObject.name == "a1")
//        //{
//        //    Destroy(a[0], 0.00000001f);

//        //}
//        //else if (other.gameObject.name == "a2")
//        //{
//        //    Destroy(a[1], 0.00000001f);
//        //}
//        //else if (other.gameObject.name == "a3")
//        //{
//        //    Destroy(a[2], 0.00000001f);
//        //}
//        //else if (other.gameObject.name == "a4")
//        //{
//        //    Destroy(a[3], 0.00000001f);
//        //}
//        //else if (other.gameObject.name == "a5")
//        //{
//        //    Destroy(a[4], 0.00000001f);
//        //}
//        //else if (other.gameObject.name == "a6")
//        //{
//        //    Destroy(a[5], 0.00000001f);
//        //}
//        //else if (other.gameObject.name == "a7")
//        //{
//        //    Destroy(a[6], 0.00000001f);
//        //}
//        //else if (other.gameObject.name == "a8")
//        //{
//        //    Destroy(a[7], 0.00000001f);
//        //}
//        //else if (other.gameObject.name == "a9")
//        //{
//        //    Destroy(a[8], 0.00000001f);
//        //}
//        //else if (other.gameObject.name == "a10")
//        //{
//        //    Destroy(a[9], 0.00000001f);
//        //}
//        //else if (other.gameObject.name == "a11")
//        //{
//        //    Destroy(a[10], 0.00000001f);
//        //}
//        //else if (other.gameObject.name == "a12")
//        //{
//        //    Destroy(a[11], 0.00000001f);
//        //}
//        //else if (other.gameObject.name == "a13")
//        //{
//        //    Destroy(a[12], 0.00000001f);
//        //}
//        //else {
//        //    print("개새끼야");
//        //}

//        if (other.gameObject.tag == "a1")
//        {
//            Destroy(a1, 0.00000001f);

//        }
//        else if (other.gameObject.tag == "a2")
//        {
//            Destroy(a2, 0.00000001f);
//        }
//        else if (other.gameObject.tag == "a3")
//        {
//            Destroy(a3, 0.00000001f);
//        }
//        else if (other.gameObject.tag == "a4")
//        {
//            Destroy(a4, 0.00000001f);
//        }
//        else if (other.gameObject.tag == "a5")
//        {
//            Destroy(a5, 0.00000001f);
//        }
//        else if (other.gameObject.tag == "a6")
//        {
//            Destroy(a6, 0.00000001f);
//        }
//        else if (other.gameObject.tag == "a7")
//        {
//            Destroy(a7, 0.00000001f);
//        }
//        else if (other.gameObject.tag == "a8")
//        {
//            Destroy(a8, 0.00000001f);
//        }
//        else if (other.gameObject.tag == "a9")
//        {
//            Destroy(a9, 0.00000001f);
//        }
//        else if (other.gameObject.tag == "a10")
//        {
//            Destroy(a10, 0.00000001f);
//        }
//        else if (other.gameObject.tag == "a11")
//        {
//            Destroy(a11, 0.00000001f);
//        }
//        else if (other.gameObject.tag == "a12")
//        {
//            Destroy(a12, 0.00000001f);
//        }
//        else if (other.gameObject.tag == "a13")
//        {
//            Destroy(a13, 0.00000001f);
//        }
//        else
//        {
//            print("개새끼야");
//        }



//    }



//    //if(other.gameObject.tag == "pizza")
//    //  {
//    //      print("okay");
//    //      //other.SetActive(false);
//    //      Destroy(pizza, 0.0000005f);
//    //  }
//    //  else {
//    //      print("help");
//    //  }


//}



