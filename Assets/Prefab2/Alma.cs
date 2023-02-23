using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alma : MonoBehaviour
{
    public static int almaCount = -5;

    private void Start()
    {
        almaCount = almaCount + 1;
        Debug.Log("Empieza el juego " + almaCount + " almas");
    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.CompareTag("Player"))
        {
            almaCount--;
            Debug.Log("Recogida de alma " + almaCount + " almas");

            if (almaCount == 0)
            {
                Debug.Log("El juego ha terminado");
            }

            Destroy(gameObject);
        }
    }
}