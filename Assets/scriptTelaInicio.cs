using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptTelaInicio : MonoBehaviour
{
    public void iniciar()
    {
        SceneManager.LoadScene(1);
    }
    public void sair()
    {
        Debug.Log("saindo do jogo");
        Application.Quit();
    }
}
