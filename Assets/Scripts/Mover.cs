using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float fltMoveSpeed = 25f;
  
    
   
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float fltXValue = Input.GetAxis("Horizontal") * Time.deltaTime * fltMoveSpeed;
        float fltZValue = Input.GetAxis("Vertical") * Time.deltaTime * fltMoveSpeed;
        transform.Translate(fltXValue,0,fltZValue);
    }
}
