using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class scriptControlador : MonoBehaviour
{
    public static int placar;
    public static GameObject textPlacar;
    public static GameObject textMunicao;
    public GameObject telaGameOver;
    public GameObject pc;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        textPlacar = GameObject.Find("textPlacar");
        textMunicao = GameObject.Find("textMunicao");
        placar = 0;
        textPlacar.GetComponent<TMP_Text>().text = "Placar: " + placar;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        textMunicao.GetComponent<TMP_Text>().text = "Munição: " + scriptPlayer.municao;
        if (pc == null)
        {
            camera.SetActive(true);
            telaGameOver.SetActive(true);
            Cursor.visible = true;
        }
        else
        {
            camera.transform.position = pc.transform.position;
        }

    }

    public static void incrementarPlacar(int inc)
    {
        placar += inc;
        textPlacar.GetComponent<TMP_Text>().text = "Placar: " + placar;

    }

    public void VoltarMenuInicial()
    {
        SceneManager.LoadScene(0);
    }
}
