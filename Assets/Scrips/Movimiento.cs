using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    float speed = 10f;

    Rigidbody rb;

    public Camera mainCamera;
    private Vector3 camForward;
    private Vector3 camRight;

    bool floorDetected = false;
    bool isJump = false;
    public float jumpForce = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementinput = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            movementinput.z = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movementinput.z = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movementinput.x = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            movementinput.x = -1;
        }

        Vector3 floor = transform.TransformDirection(Vector3.down);

        if (Physics.Raycast(transform.position, floor, 1.03f))
        {
            floorDetected = true;
            // print("Contacto");
        }
        else
        {
            floorDetected = false;
            // print("No Contacto");
        }

        isJump = Input.GetButtonDown("Jump");

        if (isJump && floorDetected)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }

        movementinput = movementinput.x * camRight + movementinput.z * camForward;
        camDireccion();
        Move(movementinput);
    }

    // Metodo para moverse
    void Move(Vector3 direccion)
    {
        transform.position += direccion.normalized * speed * Time.deltaTime;
    }

    // Metodo para guardar la posicion de vista frontal y derecha de la camara
    void camDireccion()
    {
        camForward = mainCamera.transform.forward;
        camRight = mainCamera.transform.right;

        camForward.y = 0;
        camRight.y = 0;

        camForward = camForward.normalized;
        camRight = camRight.normalized;
    }
}
