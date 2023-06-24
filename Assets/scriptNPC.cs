using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class scriptNPC : MonoBehaviour
{
    private NavMeshAgent agente;
    public GameObject pc;
    public GameObject[] waypoints = new GameObject[4];
    private int index = 0;
    public float maxDistancia = 2;
    private bool perseguicao = false;
    private float maxDistAlvo = 15;
    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        proximo();
    }

    // Update is called once per frame
    void Update()
    {

        destinoNpc();
        paraPerseguicao();
        
    }

    private void destinoNpc()
    {
        if (pc)
        {
            if (perseguicao || Vector3.Distance(transform.position, pc.transform.position) <= maxDistAlvo)
            {
                perseguicao = true;
                agente.SetDestination(pc.transform.position);
            }
            else if (Vector3.Distance(transform.position, agente.destination) < maxDistancia)
            {
                proximo();
            }
        }
    }

    private void paraPerseguicao()
    {
        if (pc)
        {
            if (Vector3.Distance(transform.position, pc.transform.position) >= maxDistAlvo * 2)
            {
                perseguicao = false;
            }
        }

    }

    private void proximo()
    {
        agente.SetDestination(waypoints[index++].transform.position);
        if (index >= waypoints.Length)
        {
            index = 0;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 7)
        {
            Destroy(collision.gameObject);
        }
    }
}
