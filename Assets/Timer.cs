using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timestart;
    public Text textbox;
    public GameObject button;

    public static bool timerActive = true;

    // Start is called before the first frame update
    public void Start()
    {
        textbox.text = timestart.ToString("F2");
    }

    // Update is called once per frame
    public void Update()
    {
        if (timerActive == true)
        {
            timestart += Time.deltaTime;
            textbox.text = timestart.ToString("F2");
        }
        else
        {
            Time.timeScale = 0;
        }
    }
}
