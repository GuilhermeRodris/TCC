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

    public bool mostrarExplicacao1;

    public GameObject PainelDeExplicacao1;

    public bool mostrarExplicacao2;

    public GameObject PainelDeExplicacao2;

    public bool mostrarExplicacao3;

    public GameObject PainelDeExplicacao3;


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

    public void aumentarPontuacao()
    {
        
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

    public void passarTela1()
    {
        if (PainelDeExplicacao1 == true ){
            PainelDeExplicacao1.SetActive(false);
            mostrarExplicacao1 = false;
            PainelDeExplicacao2.SetActive(true);
            mostrarExplicacao2 = true;
        }

    }

    public void passarTela2()
    {

        if (PainelDeExplicacao2 == true ){
            PainelDeExplicacao2.SetActive(false);
            mostrarExplicacao2 = false;
            PainelDeExplicacao3.SetActive(true);
            mostrarExplicacao3 = true;
        }

    }

    public void passarTela3()
    {

        if (PainelDeExplicacao3 == true ){
            PainelDeExplicacao3.SetActive(false);
            mostrarExplicacao3 = false;
        }

    }

}
