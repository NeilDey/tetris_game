using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{

    public float speed = 1.0f;

    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("a"))
        {
            transform.position += new Vector3(-1, 0, 0);

            Debug.Log(transform.position);

            
        }

        if (Input.GetKeyDown("d"))
        {
            transform.position += new Vector3(1, 0, 0);

            Debug.Log(transform.position);
            
        }

        if (Input.GetKeyDown("s") )
        {
            transform.position += new Vector3(0, -1, 0);

            Debug.Log(transform.position);

           
            
        }

        if (Input.GetKeyDown("w"))
        {
            transform.Rotate(0, 0, 90);

            Debug.Log(transform.position);

            
        }

    }

   
}