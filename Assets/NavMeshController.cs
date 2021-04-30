using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{
    public Transform goal;
    NavMeshAgent agent;
    Animator animatorController;
    public Transform mark;
    public Camera camera;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animatorController = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                agent.destination = mark.position = hit.point;
                //destination.GetComponent<AudioSource>().Play();
            }
        }
        //if(agent.isOnOffMeshLink) { animatorController.SetTrigger("jump"); }
        animatorController.SetFloat("Horizontal", transform.InverseTransformDirection(agent.velocity).x);
        animatorController.SetFloat("Vertical", transform.InverseTransformDirection(agent.velocity).y);
    }
}