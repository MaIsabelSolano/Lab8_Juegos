using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Look : MonoBehaviour
{
    //variables
    public float SensibilidadMouse = 100.0f;
    public Transform playerbody;
    float Xrotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X")*SensibilidadMouse*Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y")*SensibilidadMouse*Time.deltaTime;
        
        //eje y
        Xrotation -= MouseY;
        Xrotation = Mathf.Clamp(Xrotation, -90f, 90);

        //eje x
        transform.localRotation = Quaternion.Euler(Xrotation, 0f, 0f);
        playerbody.Rotate(Vector3.up * MouseX);

    }
}
