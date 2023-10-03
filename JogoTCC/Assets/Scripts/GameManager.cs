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

    public bool mostrarItens1;

    public GameObject Itens1;

    public bool mostrarItens2;

    public GameObject Itens2;

    public bool mostrarCalca;

    public GameObject ImagemCalca;

    public bool mostrarBlusa;

    public GameObject ImagemBlusa;

    public bool mostrarCamiseta;

    public GameObject ImagemCamiseta;

    public bool mostrarCamisetaLonga;

    public GameObject ImagemCamisetaLonga;

    public bool mostrarBermuda;

    public GameObject ImagemBermuda;

    public bool mostrarGorro;

    public GameObject ImagemGorro;

    public bool mostrarOculos;

    public GameObject ImagemOculos;

    public bool mostrarTenis;

    public GameObject ImagemTenis;



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

    public void voltarTela1()
    {
        if (PainelDeExplicacao2 == true ){
            PainelDeExplicacao2.SetActive(false);
            mostrarExplicacao2 = false;
            PainelDeExplicacao1.SetActive(true);
            mostrarExplicacao1 = true;
        }

    }

    public void abrirTela1()
    {
        if (jogoPausado == true ){
            PainelDeExplicacao1.SetActive(true);
            mostrarExplicacao1 = true;
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

    public void voltarTela2()
    {

        if (PainelDeExplicacao3 == true ){
            PainelDeExplicacao3.SetActive(false);
            mostrarExplicacao3 = false;
            PainelDeExplicacao2.SetActive(true);
            mostrarExplicacao2 = true;
        }

    }

    public void passarTela3()
    {

        if (PainelDeExplicacao3 == true ){
            PainelDeExplicacao3.SetActive(false);
            mostrarExplicacao3 = false;
        }

    }

    public void passarItens1()
    {

        if (Itens1 == true ){
            Itens1.SetActive(false);
            mostrarItens1 = false;
            Itens2.SetActive(true);
            mostrarItens2 = true;
        }

    }

    public void voltarItens1()
    {

        if (Itens2 == true ){
            Itens2.SetActive(false);
            mostrarItens2 = false;
            Itens1.SetActive(true);
            mostrarItens1 = true;
        }

    }

    public void poeCalca()
    {
        if (Itens1 == true ){
            ImagemBermuda.SetActive(false);
            mostrarBermuda = false;
        }

        if (Itens1 == true ){
            ImagemCalca.SetActive(true);
            mostrarCalca = true;
        }
    }

    public void poeBermuda()
    {
        if (Itens1 == true ){
            ImagemBermuda.SetActive(true);
            mostrarBermuda = true;
        }

        if (Itens1 == true ){
            ImagemCalca.SetActive(false);
            mostrarCalca = false;
        }
    }

    public void poeCamisetaLonga()
    {
        if (Itens1 == true ){
            ImagemCamisetaLonga.SetActive(true);
            mostrarCamisetaLonga = true;
        }

        if (Itens1 == true ){
            ImagemCamiseta.SetActive(false);
            mostrarCamiseta = false;
            ImagemBlusa.SetActive(false);
            mostrarBlusa = false;
        }
    }

    public void poeCamiseta()
    {
        if (Itens1 == true ){
            ImagemCamiseta.SetActive(true);
            mostrarCamiseta = true;
        }

        if (Itens1 == true ){
            ImagemCamisetaLonga.SetActive(false);
            mostrarCamisetaLonga = false;
            ImagemBlusa.SetActive(false);
            mostrarBlusa = false;
        }
    }

    public void poeBlusa()
    {
        if (Itens1 == true ){
            ImagemBlusa.SetActive(true);
            mostrarBlusa = true;
        }

        if (Itens1 == true ){
            ImagemCamisetaLonga.SetActive(false);
            mostrarCamisetaLonga = false;
            ImagemCamiseta.SetActive(false);
            mostrarCamiseta = false;
        }
    }

    public void poeGorro()
    {
        if (Itens1 == true && mostrarGorro == true  ){
            ImagemGorro.SetActive(false);
            mostrarGorro = false;
            return;
        }


        if (Itens1 == true ){
            ImagemGorro.SetActive(true);
            mostrarGorro = true;
            
        }

    }

    public void poeOculos()
    {
        if (Itens1 == true && mostrarOculos == true ){
            ImagemOculos.SetActive(false);
            mostrarOculos = false;
            return;
        }

        if (Itens1 == true ){
            ImagemOculos.SetActive(true);
            mostrarOculos = true;
        }

        

    }

    public void poeTenis()
    {
        if (Itens1 == true ){
            ImagemTenis.SetActive(true);
            mostrarTenis = true;
        }

    }


}
