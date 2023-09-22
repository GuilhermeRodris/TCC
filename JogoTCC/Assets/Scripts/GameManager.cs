using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int pontuacao;

    public bool jogoPausado;

    public GameObject PainelPause;


    // Start is called before the first frame update
    void Start()
    {
        pontuacao = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausarJogo();
        }
    }

    public void aumentarPontuacao(){
        
    }

    public void pausarJogo()
    {
        if (jogoPausado == true ){
            PainelPause.SetActive(false);
            Time.timeScale = 1f;
            jogoPausado = false;
        }

        else {
            PainelPause.SetActive(true);
            Time.timeScale = 0f;
            jogoPausado = true;
        }

    }
}
