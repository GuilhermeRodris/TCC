using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fases : MonoBehaviour
{
    public void IrParaOSeletor()
    {
        SceneManager.LoadScene(2);

    }


public void IrParaFase1()
    {
        SceneManager.LoadScene(3);

    }
    
    public void IrParaFase2()
    {
        SceneManager.LoadScene(4);

    }

    public void IrParaFase3()
    {
        SceneManager.LoadScene(5);

    }
}
