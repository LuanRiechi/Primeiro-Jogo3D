using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCamera : MonoBehaviour
{
    public float velRot=80;
    private Quaternion rotIni;
    private float yMouse = 0;
    // Start is called before the first frame update
    void Start()
    {
        rotIni = transform.localRotation;

    }

    // Update is called once per frame
    void Update()
    {
        yMouse += Input.GetAxisRaw("Mouse Y");
        yMouse = Mathf.Clamp(yMouse, -60, 60);

        Quaternion rotMouse = Quaternion.AngleAxis(yMouse, Vector3.left);

        transform.localRotation = rotIni * rotMouse;
    }
}
