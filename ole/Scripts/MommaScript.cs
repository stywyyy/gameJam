using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MommaScript : MonoBehaviour
{
    public GameObject goal;
    public NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        agent.SetDestination(goal.transform.position);
        gameObject.transform.rotation = Quaternion.identity;

        //transform.rotation = Quaternion.identity;
        //if (gameObject.transform.rotation.eulerAngles.y <= rotteter.y)
        //{
        //    Anim.SetBool("RightMom", true);
        //}
    }
}
