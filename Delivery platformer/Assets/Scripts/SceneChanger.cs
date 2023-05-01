using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ChangeScene();
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("City");
    }
}
