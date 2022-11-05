using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMovimiento : MonoBehaviour
{

    public float speedH;
    public float speedV;

    float derechaizquierda;
    float arribabajo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        derechaizquierda += speedH * Input.GetAxis("Mouse X");
        arribabajo -= speedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(arribabajo, derechaizquierda, 0.0f); 
    }
}
