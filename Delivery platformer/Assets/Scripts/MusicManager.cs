using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    //[SerializeField] AudioSource _music;
    private static MusicManager _musicmanager;
    private void Start()
    {
        if (_musicmanager == null)
        {
            DontDestroyOnLoad(this);
            _musicmanager = this;
        }
        else
        {
            Destroy(this);
        }
    }
}
