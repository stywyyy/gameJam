using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MommaScript : MonoBehaviour
{
    
    Vector3 rotteter;
    public Transform goal;
    NavMeshAgent agent;
    public Animator Anim;

    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
        rotteter = new Vector3(0, 90, 0);
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }
    void Update()
    {
        if(gameObject.transform.rotation.eulerAngles.y <= rotteter.y)
        {
            Anim.SetBool("RightMom", true);
        }
        else
        {
            Anim.SetBool("RightMom", false);
        }
    }
}
