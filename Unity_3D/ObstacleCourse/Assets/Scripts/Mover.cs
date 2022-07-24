using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions(); 
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();  
    }

    // Prints instructions to the console
    void PrintInstructions()
    {
        Debug.Log("Move with W A S D or arrow keys");
        Debug.Log("Avoid all walls and obstacles and reach the end goal.");
    }

    // Controls for moving the player
    void MovePlayer()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(x,0,z);
    }
}
