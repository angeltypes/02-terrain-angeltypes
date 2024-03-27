using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementRigidbody : MonoBehaviour
{

    // Update is called once per frame

    private Rigidbody rb;
    void Update()
    {
     rb.AddRelativeForce(
         movementValue.x * Time.deltaTime, 0, 
         movementValue.y *Time.deltaTime);

        rb.AddRelativeTorque(0, lookValue * Time.deltaTime, 0);
    }

    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
    }
}
