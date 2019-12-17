using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 20f;

    [SerializeField] Text countdowntext;
    // Start is called before the first frame update
    public void Start()
    {
        startingTime = 20f;
        currentTime = startingTime;
    }
     
    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdowntext.text = currentTime.ToString("0");

        if (currentTime >=3 && currentTime <6)
        {
            countdowntext.color = Color.yellow;
        }
        else if (currentTime < 3)
        {
            countdowntext.color = Color.red;
        }

        if (currentTime <= 0)
        {
            currentTime = 0;

        }
    }

    //private void Awake()
    //{
    //    DontDestroyOnLoad(gameObject);
    //}

}
