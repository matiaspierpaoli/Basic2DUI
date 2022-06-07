using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideUI : MonoBehaviour
{
    [SerializeField] private GameObject uiObject;

    public void Awake()
    {
        uiObject.SetActive(false);
    }   

    public void EnablePanel()
    {
        uiObject.SetActive(true);
    }

    public void DisablePanel()
    {
        uiObject.SetActive(false);
    }
}
