using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //set the camera possible as fix
        offset = transform.position - plane.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //set the camara to follow the plane
        transform.position = plane.transform.position + offset;
    }
}
