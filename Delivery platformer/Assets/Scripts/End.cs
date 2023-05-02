using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    [SerializeField] private LampsLogic _playerStats;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_playerStats.LampsCount == 3)
        {
            SceneManager.LoadScene("End");
        }
    }
}
