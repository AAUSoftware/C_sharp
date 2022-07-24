using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    
    Color darkMagenta = new Color(0.31f, 0f, 0.10f, 1f); 

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = darkMagenta;
            gameObject.tag = "Booped";
        }
    }
}
