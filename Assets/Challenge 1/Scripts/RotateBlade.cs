using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBlade : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this will rotate the blade of the  plane along the axiz
        transform.Rotate(Vector3.forward, 40);
        
    }
}
