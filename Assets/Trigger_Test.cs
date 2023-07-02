using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Test : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger");
    }
}
