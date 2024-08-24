using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public float topClamp = -90f;
    public float bottomClamp = 90f;
    float xRotation = 0f;
    float yRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        //x axis ,look up and down
        xRotation -= mouseY;
        //we not wtire mouse X because char dont walk to anywhere
        xRotation = Mathf.Clamp(xRotation, topClamp, bottomClamp);
        //y axis ,look left and right
        yRotation += 1;
        //apply rotations t0 our transform
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}
