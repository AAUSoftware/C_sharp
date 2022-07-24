using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
  
    MeshRenderer renderer;
    Rigidbody body;

    [SerializeField] float dropTime = 3f;

    void Start() {
        renderer = GetComponent<MeshRenderer>();
        body = GetComponent<Rigidbody>();

        renderer.enabled = false;
        body.useGravity = false;

    }
   
    void Update()
    {
       if (Time.time > dropTime) 
       {
            renderer.enabled = true;
            body.useGravity = true;
       }
    }


}
