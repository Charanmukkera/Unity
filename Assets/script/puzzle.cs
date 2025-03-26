using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle : MonoBehaviour
{
    [SerializeField] float objectMove = 100f;
    [SerializeField] float rotationThrust = 1f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
        ProcessRotation();
    }
    void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(force: Vector3.up * objectMove * Time.deltaTime);
        }
    }
    void ProcessRotation()
    {
        if(Input.GetKey(KeyCode.A))
        {
            InputMove(-rotationThrust);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            InputMove(rotationThrust);
        }
    }

    private void InputMove(float TheRotation)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * TheRotation * Time.deltaTime);
        rb.freezeRotation = false;
    }
}
