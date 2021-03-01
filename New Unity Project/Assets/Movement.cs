using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Transform MainCamera;

    // Start is called before the first frame update
    void Start()
    {
        MainCamera = GetComponent<Transform>();
    }


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, 10f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(10f * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-10f * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -10f * Time.deltaTime);
        }
    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
