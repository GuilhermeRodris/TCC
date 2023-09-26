using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeletorDePersonagens : MonoBehaviour
{
    public GameObject[] characterOptions; // Uma matriz de GameObjects representando os personagens disponíveis.
    public Image characterDisplay; // A imagem na tela que mostrará o personagem selecionado.
    private int selectedCharacterIndex = 0; // O índice do personagem atualmente selecionado.

    private void Start()
    {
        UpdateCharacterDisplay();
    }

    public void SelectCharacter(int characterIndex)
    {
        selectedCharacterIndex = characterIndex;
        UpdateCharacterDisplay();
        GameManager.Instance.SetSelectedCharacter(characterOptions[selectedCharacterIndex]); // Envie o personagem selecionado para o GameManager.
    }

    private void UpdateCharacterDisplay()
    {
        characterDisplay.sprite = characterOptions[selectedCharacterIndex].GetComponent<SpriteRenderer>().sprite;
    }
}
