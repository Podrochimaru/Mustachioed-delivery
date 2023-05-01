using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LampsLogic : MonoBehaviour
{
    public int LampsCount = 0;
    private void Update()
    {
        if (LampsCount == 3)
        {
            Debug.Log("Три фонаря зажжены");
        }
    }
}
