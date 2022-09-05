using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int intHits = 0; 
    private void OnCollisionEnter(Collision other) 
    {
        intHits++;
        Debug.Log("Score: " + intHits);
    }
}

 
