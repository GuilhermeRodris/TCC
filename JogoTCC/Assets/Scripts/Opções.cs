using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opções : MonoBehaviour
{
    public void IrParaAsOpcoes()
    {
        SceneManager.LoadScene(1);

    }
    
    public void VoltaMenuPrincipal()
    {
        SceneManager.LoadScene(0);

    }
}
