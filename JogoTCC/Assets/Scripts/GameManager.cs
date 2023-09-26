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

    public GameObject[] characterPrefabs; // Lista de prefabs dos personagens

    public Transform characterSpawnPoint; // Ponto de spawn do personagem

    public Text characterNameText; // Texto para mostrar o nome do personagem selecionado

    private int selectedCharacterIndex = 0; // Índice do personagem selecionado



    // Start is called before the first frame update
    void Start()
    {
        pontuacao = 0;
        SpawnCharacter();
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

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public void NextCharacter()
    {
        selectedCharacterIndex = (selectedCharacterIndex + 1) % characterPrefabs.Length;
        SpawnCharacter();
    }

    public void PreviousCharacter()
    {
        selectedCharacterIndex = (selectedCharacterIndex - 1 + characterPrefabs.Length) % characterPrefabs.Length;
        SpawnCharacter();
    }

    private void SpawnCharacter()
    {
        // Destrua o personagem atual (se houver)
        foreach (Transform child in characterSpawnPoint)
        {
            Destroy(child.gameObject);
        }

        // Instancie o novo personagem
        GameObject selectedCharacter = Instantiate(characterPrefabs[selectedCharacterIndex], characterSpawnPoint.position, Quaternion.identity);
        selectedCharacter.transform.SetParent(characterSpawnPoint);

        // Atualize o texto com o nome do personagem selecionado
        characterNameText.text = selectedCharacter.name;
    }
    
}
