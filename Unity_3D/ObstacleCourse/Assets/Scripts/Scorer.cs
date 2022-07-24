using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int Score = 0;
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag != "Booped")
        {
            Score++;
            Debug.Log("Boop count: " + Score);
        }
    }
}
