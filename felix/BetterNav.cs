using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BetterNav : MonoBehaviour
{

    //
    Vector3 rotteter;
    public Animator Anim;
    //
    public GameObject deinSOngoku; 
    Transform goal;
    NavMeshAgent agent;

    void Start()
    {
        //
        Anim = gameObject.GetComponent<Animator>();
        rotteter = new Vector3(0, 90, 0);
        //
        agent = GetComponent<NavMeshAgent>();
       
    }
    void Update()
    {
        goal = deinSOngoku.transform;
        agent.Move(goal.position);
        agent.destination = goal.position;
        //
        if (gameObject.transform.rotation.eulerAngles.y <= rotteter.y)
        {
            Anim.SetBool("RightMom", true);
        }
        else
        {
            Anim.SetBool("RightMom", false);
        }
        //
    }
}
