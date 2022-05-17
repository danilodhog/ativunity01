using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour
{
    public GameObject scoretext;
    public static int thescore;
    
  

    // Update is called once per frame
    void Update()
    {
        scoretext.GetComponent<Text>().text = "Points: " + thescore;
    }
}
