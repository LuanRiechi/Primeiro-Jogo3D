using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPortal : MonoBehaviour
{
    public GameObject cameraPortal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 7)
        {
            other.gameObject.transform.position = cameraPortal.transform.position;
        }
    }
}
