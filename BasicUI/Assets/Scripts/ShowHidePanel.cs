using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHidePanel : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    public void Awake()
    {
        panel.SetActive(false);
    }

    public void EnablePanel()
    {
        panel.SetActive(true);
    }

    public void DisablePanel()
    {
        panel.SetActive(false);
    }
}
