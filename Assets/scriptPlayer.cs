using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPlayer : MonoBehaviour
{
    private Rigidbody rbd;
    public float vel;
    public float velRot;
    private Quaternion rotIni;
    private float xMouse = 0;
    public GameObject cabeca;
    public float dist = 100;
    public LayerMask mascara;
    private AudioSource som;
    public static int municao;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        som = GetComponent<AudioSource>();
        vel = 10;
        velRot = 80;
        rotIni = transform.localRotation;
        rbd = GetComponent<Rigidbody>();
        municao = 1;
    }

    // Update is called once per frame
    void Update()
    {
        float frente = Input.GetAxis("Vertical");
        float lado = Input.GetAxis("Horizontal");

        rbd.velocity = transform.TransformDirection(
                           new Vector3(lado * vel,
                                   rbd.velocity.y,
                                   frente * vel));

        //Definindo o quanto o mouse movimentou no seu eixo X
        xMouse += Input.GetAxisRaw("Mouse X") *
                        Time.deltaTime * velRot;

        //Convertendo o movimento do  mouse em rotação no 
        //eixo y (representação em Quaternion)
        Quaternion rotMouse =
              Quaternion.AngleAxis(xMouse, Vector3.up);

        //Aplicando a rotação no PC
        transform.localRotation = rotIni * rotMouse;


            if (Input.GetMouseButtonDown(0))
            {
                if (municao > 0)
                {
                    municao--;
                    som.Play();
                    RaycastHit hit;
                    if (Physics.Raycast(cabeca.transform.position,
                                        cabeca.transform.forward,
                                        out hit,
                                        dist,
                                        mascara))
                    {

                        Rigidbody rbA;
                        rbA = hit.collider.GetComponent<Rigidbody>();
                        rbA.AddForce(cabeca.transform.forward * 500);

                    }

                }

            }

    }
}

