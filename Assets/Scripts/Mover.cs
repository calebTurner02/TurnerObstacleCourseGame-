using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
  
    
   
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float fltXValue = Input.GetAxis("Horizontal");
        float fltZValue = Input.GetAxis("Vertical");
        transform.Translate(fltXValue,0,fltZValue);
    }
}
