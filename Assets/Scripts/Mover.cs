using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float fltMoveSpeed = 25f;
  
    
   
   
    // Start is called before the first frame update
    void Start()
    {
       PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
      MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome!");
        Debug.Log("Move with WASD");
        Debug.Log("Don't hit walls");

    }
     void MovePlayer()
    {
         float fltXValue = Input.GetAxis("Horizontal") * Time.deltaTime * fltMoveSpeed;
        float fltZValue = Input.GetAxis("Vertical") * Time.deltaTime * fltMoveSpeed;
        transform.Translate(fltXValue,0,fltZValue);
    }
}
