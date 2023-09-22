using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botoes : MonoBehaviour
{
    public void IrParaOSeletorDeFases()
    {
        SceneManager.LoadScene(2);

    }


    public void Sair()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void IrParaAsOpcoes()
    {
        SceneManager.LoadScene(1);

    }
    
    public void VoltaMenuPrincipal()
    {
        SceneManager.LoadScene(0);

    }

    public void IrParaOsCreditos()
    {
        SceneManager.LoadScene(6);

    }
}
