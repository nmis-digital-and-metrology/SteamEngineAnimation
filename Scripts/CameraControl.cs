using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Camera cam;
    private float rotateSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xAxisValue = Input.GetAxis("Horizontal");
        float zAxisValue = Input.GetAxis("Vertical");
        cam.transform.Translate(new Vector3(xAxisValue, 0.0f, zAxisValue));

        if (Input.GetKey(KeyCode.R))
        {

            cam.transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed);
        }
        if (Input.GetKey(KeyCode.T))
        {

            cam.transform.Rotate(-Vector3.up, Time.deltaTime * rotateSpeed);


        }
    }
}
