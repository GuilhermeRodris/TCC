using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoSair : MonoBehaviour
{
    // Start is called before the first frame update
    public void Sair()
    {
        // Verifica se a aplicação está rodando no Editor do Unity.
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
