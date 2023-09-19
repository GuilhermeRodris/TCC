using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabPageUIController : MonoBehaviour
{ 
    [SerializeField] private Image buttonBackground;
    [SerializeField] private Image buttonIcon;
    [SerializeField] private Image selectedColor;
    [SerializeField] private Image unselectedColor;

    private TabPage tabPage;

    public TabPage TabPage
    {
        get { return tabPage; }
        set
        {
           tabPage = value;
           buttonIcon.sprite = tabPage.icon;
        }

    }

    public event Action<TabPageUIController> OnPageSelected;

    public void Select(bool selected){
        buttonBackground.color = selected ? selectedColor.color : unselectedColor.color;
    }

    public bool IsVisible => gameObject.activeSelf;

    public void SetVisibility(bool IsVisible){
        gameObject.SetActive(IsVisible);
    }

    public void OnClick() {
        OnPageSelected?.Invoke(this);
    }
    
}
