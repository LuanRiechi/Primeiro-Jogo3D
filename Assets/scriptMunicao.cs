using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptMunicao : MonoBehaviour
{
    // Start is called before the first frame update

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            scriptPlayer.municao++;
            Destroy(this.gameObject);
        }
    }
}
