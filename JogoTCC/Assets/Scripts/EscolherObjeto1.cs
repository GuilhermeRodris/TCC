using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscolherObjeto1 : MonoBehaviour
{
    public GameManager gameManager;

    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        gameManager.poeObjeto1();
    }
}
