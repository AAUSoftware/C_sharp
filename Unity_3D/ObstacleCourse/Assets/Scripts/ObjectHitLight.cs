using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHitLight : MonoBehaviour
{
    
    Color darkMagenta = new Color(1f, 0f, 0.35f, 1f); 

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = darkMagenta;
            gameObject.tag = "Booped";
        }
    }
}
