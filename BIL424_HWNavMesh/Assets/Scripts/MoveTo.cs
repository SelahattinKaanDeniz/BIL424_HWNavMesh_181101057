using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MoveTo : MonoBehaviour
{
    public Transform cube;
    NavMeshAgent cylinderNavAgent;
    RaycastHit hit;
    Ray ray;
    float cubeposx;
    float cubeposz;
   
    void Start()
    {

        cylinderNavAgent = GetComponent<NavMeshAgent>();
        cube = GameObject.FindGameObjectWithTag("Cube").transform;
        cubeposx = cube.position.x;
        cubeposz = cube.position.z;
        Debug.Log(cube.position);
        cylinderNavAgent.destination = cube.position;
        
    }

    void Update()
    {
        if(this.transform.position.x== cubeposx && this.transform.position.z == cubeposz)
        {
            Debug.Log("Reached to cube");
            SceneManager.LoadScene(1);
        }
        if (Input.GetMouseButton(0))
        {     
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                cylinderNavAgent.SetDestination(hit.point);
            }
        }
        else
        {
            cube = GameObject.FindGameObjectWithTag("Cube").transform;
            cylinderNavAgent.SetDestination(cube.position);
        }
      

    }
}
