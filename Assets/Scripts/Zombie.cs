using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
// using UnityEngine.InputSystem;


public class Zombie : MonoBehaviour
{
    public float velocity = 4f;
    public float anglularVelocity = 50f;
    NavMeshAgent agent;
    public Camera cam;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        cam = Camera.main;   
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position += moveDir * transform.forward * velocity * Time.deltaTime;
        // transform.rotation *= Quaternion.Euler(0, Mathf.Sign(moveDir) * rotDir * Time.deltaTime * anglularVelocity, 0);
        // Vector3 mousePos = Mouse.current.position.ReadValue();
        cam = Camera.main;
        RaycastHit hit;
        if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit))
        {
            Debug.Log("Hi");
            agent.SetDestination(hit.point);
        }
    }
}
