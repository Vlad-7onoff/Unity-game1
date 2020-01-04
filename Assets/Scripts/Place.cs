using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke("Deactivate", 30f);
    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
