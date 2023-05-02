using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxDialogue : MonoBehaviour
{
    [SerializeField] private GameObject _dialogue;
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log("Rofls1");
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Debug.Log("Rofls");
            _dialogue.SetActive(true);
            Invoke("EndDialogue", 8f);
        }
    }
    private void EndDialogue()
    {
        _dialogue.SetActive(false);
    }
}
