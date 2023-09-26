using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private void Start()
    {
        GameObject selectedCharacter = GameManager.Instance.GetSelectedCharacter();

        if (selectedCharacter != null)
        {
            // Instancie o personagem selecionado na fase.
            Instantiate(selectedCharacter, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Personagem não selecionado!");
        }
    }

}
