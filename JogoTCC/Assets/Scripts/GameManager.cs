using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //precisa para sistema de pontuação
    public int pontuacao;

    //Precisa pra pausar o jogo
    public bool jogoPausado;

    public GameObject PainelPause;

    //Precisa pra controlar as telas de explicações

    public bool mostrarExplicacao1;

    public GameObject PainelDeExplicacao1;

    public bool mostrarExplicacao2;

    public GameObject PainelDeExplicacao2;

    public bool mostrarExplicacao3;

    public GameObject PainelDeExplicacao3;

    // Precisa pra mostrar os diferentes itens do armario

    public bool mostrarItens1;

    public GameObject Itens1;

    public bool mostrarItens2;

    public GameObject Itens2;

    public bool mostrarItens3;

    public GameObject Itens3;

    public bool mostrarItens4;

    public GameObject Itens4;

    //Precisa pros botoes das roupas

    // Roupas parte de cima
    public bool mostrarCamisa;

    public GameObject ImagemCamisa;

    public bool mostrarCamiseta1;

    public GameObject ImagemCamiseta1;

    public bool mostrarCamiseta2;

    public GameObject ImagemCamiseta2;

    public bool mostrarMangaLonga1;

    public GameObject ImagemMangaLonga1;

    public bool mostrarMangaLonga2;

    public GameObject ImagemMangaLonga2;

    public bool mostrarBlusa1;

    public GameObject ImagemBlusa1;

    public bool mostrarBlusa2;

    public GameObject ImagemBlusa2;

    //Roupas parte de baixo
    public bool mostrarBermuda1;

    public GameObject ImagemBermuda1;

    public bool mostrarBermuda2;

    public GameObject ImagemBermuda2;

    public bool mostrarCalca1;

    public GameObject ImagemCalca1;

    public bool mostrarCalca2;

    public GameObject ImagemCalca2;

    public bool mostrarTenis;

    public GameObject ImagemTenis;

    public bool mostrarChinelo;

    public GameObject ImagemChinelo;

    //Acessorios
    public bool mostrarGorro;

    public GameObject ImagemGorro;

    public bool mostrarOculos;

    public GameObject ImagemOculos;

    public bool mostrarCachecol;

    public GameObject ImagemCachecol;

    //Os objetos das pras crianças

    public bool mostrarObjeto1;

    public GameObject Objeto1;

    public bool mostrarObjeto2;

    public GameObject Objeto2;

    public bool mostrarObjeto3;

    public GameObject Objeto3;

    public bool mostrarObjeto4;

    public GameObject Objeto4;

    public bool mostrarObjeto5;

    public GameObject Objeto5;

    public bool mostrarObjeto6;

    public GameObject Objeto6;

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

//Controle de pause do jogo

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

//Configurações das intruções

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

//Controle de troca de quais itens estao no armario

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

    public void passarItens2()
    {

        if (Itens2 == true ){
            Itens2.SetActive(false);
            mostrarItens2 = false;
            Itens3.SetActive(true);
            mostrarItens3 = true;
        }

    }

    public void voltarItens2()
    {

        if (Itens3 == true ){
            Itens3.SetActive(false);
            mostrarItens3 = false;
            Itens2.SetActive(true);
            mostrarItens2 = true;
        }

    }

    public void passarItens3()
    {

        if (Itens3 == true ){
            Itens3.SetActive(false);
            mostrarItens3 = false;
            Itens4.SetActive(true);
            mostrarItens4 = true;
        }

    }

    public void voltarItens3()
    {

        if (Itens4 == true ){
            Itens4.SetActive(false);
            mostrarItens4 = false;
            Itens3.SetActive(true);
            mostrarItens3 = true;
        }

    }

//Armario Itens 1

    public void poeCamisa()
    {
        if (Itens1 == true ){
            ImagemCamisa.SetActive(true);
            mostrarCamisa = true;
        }

        if (Itens1 == true ){
            ImagemCamiseta1.SetActive(false);
            mostrarCamiseta1 = false;
            ImagemCamiseta2.SetActive(false);
            mostrarCamiseta2 = false;
            ImagemMangaLonga1.SetActive(false);
            mostrarMangaLonga1 = false;
            ImagemMangaLonga2.SetActive(false);
            mostrarMangaLonga2 = false;
            ImagemBlusa1.SetActive(false);
            mostrarBlusa1 = false;
            ImagemBlusa2.SetActive(false);
            mostrarBlusa2 = false;
        }
    }

    public void poeCamiseta1()
    {
        if (Itens1 == true ){
            ImagemCamiseta1.SetActive(true);
            mostrarCamiseta1 = true;
        }

        if (Itens1 == true ){
            ImagemCamisa.SetActive(false);
            mostrarCamisa = false;
            ImagemCamiseta2.SetActive(false);
            mostrarCamiseta2 = false;
            ImagemMangaLonga1.SetActive(false);
            mostrarMangaLonga1 = false;
            ImagemMangaLonga2.SetActive(false);
            mostrarMangaLonga2 = false;
            ImagemBlusa1.SetActive(false);
            mostrarBlusa1 = false;
            ImagemBlusa2.SetActive(false);
            mostrarBlusa2 = false;
        }
    }

    public void poeCamiseta2()
    {
        if (Itens1 == true ){
            ImagemCamiseta2.SetActive(true);
            mostrarCamiseta2 = true;
        }

        if (Itens1 == true ){
            ImagemCamisa.SetActive(false);
            mostrarCamisa = false;
            ImagemCamiseta1.SetActive(false);
            mostrarCamiseta1 = false;
            ImagemMangaLonga1.SetActive(false);
            mostrarMangaLonga1 = false;
            ImagemMangaLonga2.SetActive(false);
            mostrarMangaLonga2 = false;
            ImagemBlusa1.SetActive(false);
            mostrarBlusa1 = false;
            ImagemBlusa2.SetActive(false);
            mostrarBlusa2 = false;
        }
    }

    public void poeMangaLonga1()
    {
        if (Itens1 == true ){
            ImagemMangaLonga1.SetActive(true);
            mostrarMangaLonga1 = true;
        }

        if (Itens1 == true ){
            ImagemCamisa.SetActive(false);
            mostrarCamisa = false;
            ImagemCamiseta1.SetActive(false);
            mostrarCamiseta1 = false;
            ImagemCamiseta2.SetActive(false);
            mostrarCamiseta2 = false;
            ImagemMangaLonga2.SetActive(false);
            mostrarMangaLonga2 = false;
            ImagemBlusa1.SetActive(false);
            mostrarBlusa1 = false;
            ImagemBlusa2.SetActive(false);
            mostrarBlusa2 = false;
        }
    }

    public void poeMangaLonga2()
    {
        if (Itens1 == true ){
            ImagemMangaLonga2.SetActive(true);
            mostrarMangaLonga2 = true;
        }

        if (Itens1 == true ){
            ImagemCamisa.SetActive(false);
            mostrarCamisa = false;
            ImagemCamiseta1.SetActive(false);
            mostrarCamiseta1 = false;
            ImagemCamiseta2.SetActive(false);
            mostrarCamiseta2 = false;
            ImagemMangaLonga1.SetActive(false);
            mostrarMangaLonga1 = false;
            ImagemBlusa1.SetActive(false);
            mostrarBlusa1 = false;
            ImagemBlusa2.SetActive(false);
            mostrarBlusa2 = false;
        }
    }

     public void poeBlusa1()
    {
        if (Itens1 == true ){
            ImagemBlusa1.SetActive(true);
            mostrarBlusa1 = true;
        }

        if (Itens1 == true ){
            ImagemCamisa.SetActive(false);
            mostrarCamisa = false;
            ImagemCamiseta1.SetActive(false);
            mostrarCamiseta1 = false;
            ImagemCamiseta2.SetActive(false);
            mostrarCamiseta2 = false;
            ImagemMangaLonga1.SetActive(false);
            mostrarMangaLonga1 = false;
            ImagemMangaLonga2.SetActive(false);
            mostrarMangaLonga2 = false;
            ImagemBlusa2.SetActive(false);
            mostrarBlusa2 = false;
        }
    }

     public void poeBlusa2()
    {
        if (Itens1 == true ){
            ImagemBlusa2.SetActive(true);
            mostrarBlusa2 = true;
        }

        if (Itens1 == true ){
            ImagemCamisa.SetActive(false);
            mostrarCamisa = false;
            ImagemCamiseta1.SetActive(false);
            mostrarCamiseta1 = false;
            ImagemCamiseta2.SetActive(false);
            mostrarCamiseta2 = false;
            ImagemMangaLonga1.SetActive(false);
            mostrarMangaLonga1 = false;
            ImagemMangaLonga2.SetActive(false);
            mostrarMangaLonga2 = false;
            ImagemBlusa1.SetActive(false);
            mostrarBlusa1 = false;
        }
    }
//Armario Itens 2
    public void poeBermuda1()
    {
        if (Itens2 == true ){
            ImagemBermuda1.SetActive(true);
            mostrarBermuda1 = true;
        }

        if (Itens1 == true ){
            ImagemBermuda2.SetActive(false);
            mostrarBermuda2 = false;
            ImagemCalca1.SetActive(false);
            mostrarCalca1 = false;
            ImagemCalca2.SetActive(false);
            mostrarCalca2 = false;
        }
    }

    public void poeBermuda2()
    {
        if (Itens2 == true ){
            ImagemBermuda2.SetActive(true);
            mostrarBermuda2 = true;
        }

        if (Itens2 == true ){
            ImagemBermuda1.SetActive(false);
            mostrarBermuda1 = false;
            ImagemCalca1.SetActive(false);
            mostrarCalca1 = false;
            ImagemCalca2.SetActive(false);
            mostrarCalca2 = false;
        }
    }

      public void poeCalca1()
    {
        if (Itens2 == true ){
            ImagemCalca1.SetActive(true);
            mostrarCalca1 = true;
        }

        if (Itens2 == true ){
            ImagemBermuda1.SetActive(false);
            mostrarBermuda1 = false;
            ImagemBermuda2.SetActive(false);
            mostrarBermuda2 = false;
            ImagemCalca2.SetActive(false);
            mostrarCalca2 = false;
        }
    }

    public void poeCalca2()
    {
        if (Itens2 == true ){
            ImagemCalca2.SetActive(true);
            mostrarCalca2 = true;
        }

        if (Itens2 == true ){
            ImagemBermuda1.SetActive(false);
            mostrarBermuda1 = false;
            ImagemBermuda2.SetActive(false);
            mostrarBermuda2 = false;
            ImagemCalca1.SetActive(false);
            mostrarCalca1 = false;
        }
    }

    public void poeTenis()
    {
        if (Itens2 == true ){
            ImagemTenis.SetActive(true);
            mostrarTenis = true;
        }

         if (Itens2 == true ){
            ImagemChinelo.SetActive(false);
            mostrarChinelo = false;
        }

    }

    public void poeChinelo()
    {
        if (Itens2 == true ){
            ImagemChinelo.SetActive(true);
            mostrarChinelo = true;
        }

         if (Itens2 == true ){
            ImagemTenis.SetActive(false);
            mostrarTenis = false;
        }

    }

    //itens 3

    public void poeGorro()
    {
        if (Itens3 == true && mostrarGorro == true  ){
            ImagemGorro.SetActive(false);
            mostrarGorro = false;
            return;
        }


        if (Itens3 == true ){
            ImagemGorro.SetActive(true);
            mostrarGorro = true;
            
        }

    }

    public void poeOculos()
    {
        if (Itens3 == true && mostrarOculos == true ){
            ImagemOculos.SetActive(false);
            mostrarOculos = false;
            return;
        }

        if (Itens3 == true ){
            ImagemOculos.SetActive(true);
            mostrarOculos = true;
        }

    }

    public void poeCachecol()
    {
        if (Itens3 == true && mostrarCachecol == true ){
            ImagemCachecol.SetActive(false);
            mostrarCachecol = false;
            return;
        }

        if (Itens3 == true ){
            ImagemCachecol.SetActive(true);
            mostrarCachecol = true;
        }

    }

    //itens 4

    public void poeObjeto1()
    {
        if (Itens4 == true && mostrarObjeto1 == true ){
            Objeto1.SetActive(false);
            mostrarObjeto1 = false;
            return;
        }

        if (Itens4 == true ){
            Objeto1.SetActive(true);
            mostrarObjeto1 = true;
        }

    }

    public void poeObjeto2()
    {
        if (Itens4 == true && mostrarObjeto2 == true ){
            Objeto2.SetActive(false);
            mostrarObjeto2 = false;
            return;
        }

        if (Itens4 == true ){
            Objeto2.SetActive(true);
            mostrarObjeto2 = true;
        }

    }

    public void poeObjeto3()
    {
        if (Itens4 == true && mostrarObjeto3 == true ){
            Objeto3.SetActive(false);
            mostrarObjeto3 = false;
            return;
        }

        if (Itens4 == true ){
            Objeto3.SetActive(true);
            mostrarObjeto3 = true;
        }

    }

    public void poeObjeto4()
    {
        if (Itens4 == true && mostrarObjeto4 == true ){
            Objeto4.SetActive(false);
            mostrarObjeto4 = false;
            return;
        }

        if (Itens4 == true ){
            Objeto4.SetActive(true);
            mostrarObjeto4 = true;
        }

    }

    public void poeObjeto5()
    {
        if (Itens4 == true && mostrarObjeto5 == true ){
            Objeto5.SetActive(false);
            mostrarObjeto5 = false;
            return;
        }

        if (Itens4 == true ){
            Objeto5.SetActive(true);
            mostrarObjeto5 = true;
        }

    }

    public void poeObjeto6()
    {
        if (Itens4 == true && mostrarObjeto6 == true ){
            Objeto6.SetActive(false);
            mostrarObjeto6 = false;
            return;
        }

        if (Itens4 == true ){
            Objeto6.SetActive(true);
            mostrarObjeto6 = true;
        }

    }
}
