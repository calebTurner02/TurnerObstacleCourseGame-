using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float fltxValue = 0.01f;
   [SerializeField] float fltyValue = 0.01f;
   [SerializeField] float fltzValue = 0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(fltxValue,fltyValue,fltzValue);
    }
}
