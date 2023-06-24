using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scriptControlador : MonoBehaviour
{
    public static int placar;
    public static GameObject textPlacar;
    public static GameObject textMunicao;
    // Start is called before the first frame update
    void Start()
    {
        textPlacar = GameObject.Find("textPlacar");
        textMunicao = GameObject.Find("textMunicao");
        placar = 0;
        textPlacar.GetComponent<TMP_Text>().text = "Placar: " + placar;
    }

    // Update is called once per frame
    void Update()
    {
        textMunicao.GetComponent<TMP_Text>().text = "Munição: " + scriptPlayer.municao;
    }

    public static void incrementarPlacar(int inc)
    {
        placar += inc;
        textPlacar.GetComponent<TMP_Text>().text = "Placar: " + placar;

    }
}
