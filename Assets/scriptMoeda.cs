using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptMoeda : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            scriptControlador.incrementarPlacar(1);
            Destroy(this.gameObject);
        }
    }
}
