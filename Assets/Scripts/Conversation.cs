/* ***************************************************************
 * 프로그램 명 : Conversation.cs
 * 작성자 : 이송이 (류서현, 신은지, 최세화, 최은정, 홍예지)
 * 최조 작성일 : 2019년 11월 25일
 * 최종 작성일 : 2019년 12월 05일
 * 프로그램 설명 : 파일 입출력으로 Scene에 맞는 대화를 불러온 뒤
 *                      게임 화면에 대화 형식으로 보여준다.
 * *************************************************************** */

using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Conversation : MonoBehaviour
{
    // 게임 오브젝트들을 불러온다.
    public GameObject ConversationBox;
    public GameObject ConversationMark;
    public GameObject ConversationDad;
    public GameObject ConversationApple;
    public GameObject ConversationPine;
    public GameObject ConversationText;
    public Text ConverText;
    
    // initialize text file's path
    private string sceneData;

    private bool isPrint = false;
    private TextAsset data;
    private StringReader reader;
    private string buff = "";

    private void Awake()
    {
        // 어느 상황인지 고양이에 저장된 컴포넌트에서 SceneData불러오기.(수정해야함)
        sceneData = "RD1PREC";
    }

    // Start is called before the first frame update
    void Start()
    {
        // 장면에 알맞은 파일 오픈
        data = Resources.Load(sceneData, typeof(TextAsset)) as TextAsset;
        reader = new StringReader(data.text);
        // buff에 한 줄 받아오기 
        buff = reader.ReadLine();
        Debug.Log(buff); // 현재 상황을 Console에 표시

        // buff에 한 줄 받아오기(씬 정보 받아오기)
        buff = reader.ReadLine();
        if (buff != sceneData) // 현재 씬과 다른 씬이면 그 씬으로 이동한다.
        {
            // 은정이가 만든 씬 이동 함수 이용(수정해야함)
        }

        // 2초마다 DoConversation함수 호출
        InvokeRepeating("DoConversation", 0, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void start_con()
    {
    }

    void DoConversation()
    {
        buff = reader.ReadLine();
        string[] values; // string 배열 선언 (화자와 대사 저장)

        if (buff != null) // buff에 파일 내용이 들어왔다면
        {
            values = buff.Split(','); // 쉼표 단위로 한 줄을 split하여 values에 차례로 넣는다
            if (values.Length == 0)
            {
                reader.Close();
                isPrint = true;
                return;
            }
            // 대화창을 활성화한다.
            ConversationBox.SetActive(true);
            ConversationMark.SetActive(true);
            // 화자를 띄운다.
            if (values[0] == "DAD") // 화자가 아빠이면 
            {
                ConversationApple.SetActive(false);
                ConversationPine.SetActive(false);
                ConversationDad.SetActive(true);
            }
            else if (values[0] == "APPLE") // 화자가 애플이면
            {
                ConversationDad.SetActive(false);
                ConversationPine.SetActive(false);
                ConversationApple.SetActive(true);
            }
            else if (values[0] == "PINE") // 화자가 파인이면
            {
                ConversationDad.SetActive(false);
                ConversationApple.SetActive(false);
                ConversationPine.SetActive(true);
            }
            
            //TextBox 내용을 values[1]로 바꾸기
            ConverText.text = values[1];
            //대화를 보여준다.
            ConversationText.SetActive(true);
        }
        else // 파일이 끝나면
        {
            ConversationSkip();
        }
    }

    void ConversationSkip() // skip동작시 호출 
    {
        // 대화 상자들을 모두 비활성화한다.
        CancelInvoke("DoConversation");
        ConversationBox.SetActive(false);
        ConversationMark.SetActive(false);
        ConversationText.SetActive(false);
        ConversationDad.SetActive(false);
        ConversationApple.SetActive(false);
        ConversationPine.SetActive(false);
    }
}
