using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    private void Start()
    {
        Invoke("CloseDialog", 5f);
    }
    private void CloseDialog()
    {
        _panel.SetActive(false);
    }
}
