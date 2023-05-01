using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampScript : MonoBehaviour
{
    [SerializeField] private GameObject _lamp;
    [SerializeField] private LampsLogic _playerStats;
    private bool _isActive = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_isActive == false)
        {
           _lamp.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
            _playerStats.LampsCount++;
            _isActive = true;
        }
    }
}
