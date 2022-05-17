using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score2 : MonoBehaviour
{
    
    // Update is called once per frame
    void OnTriggerEnter(Collider Other)
    {
        Destroy(gameObject);
        scoring.thescore += 1;
    }
}
