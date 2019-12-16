using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeControl : MonoBehaviour
{
    public int life;
    public GameObject Life1;
    public GameObject Life2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("life : " + life);
        Life1.SetActive(false);
        Life2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
