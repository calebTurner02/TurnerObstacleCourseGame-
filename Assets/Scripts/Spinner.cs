using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField]float fltXRotate = 4f;
     [SerializeField]float fltYRotate = 4f;
      [SerializeField]float fltZRotate = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(fltXRotate, fltYRotate, fltZRotate);
    }
}
