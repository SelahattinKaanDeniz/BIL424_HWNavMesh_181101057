using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public Transform playerBody; // The transform of our player body/mesh

    private void Start() // Called at game start
    {     
   
    }

    private void Update() // Called once per frame
    {
        transform.position = playerBody.position + new Vector3(0, +33, 0);
    }
}
