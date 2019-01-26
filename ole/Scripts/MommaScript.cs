using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MommaScript : MonoBehaviour
{
    
    Vector3 Right;
    Vector3 Left;
    Vector3 Forward;
    public GameObject goal;
    NavMeshAgent agent;
    //public Animator Anim;

    void Start()
    {
        //Anim = gameObject.GetComponent<Animator>();
        Right = new Vector3(0, 90, 0);
        Left = new Vector3(0, 90, 0);
        Forward = new Vector3(0, 90, 0);
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        agent.SetDestination(goal.transform.position);
        gameObject.transform.rotation = Quaternion.identity;
        //if(gameObject.transform.rotation.eulerAngles.y <= Right.y && )
        //{
        //    Anim.SetBool("RightMom", true);
        //    Anim.SetBool("LeftMom", false);
        //    Anim.SetBool("Walk", true);
        //}
        //if (gameObject.transform.rotation.eulerAngles.y <= Left.y)
        //{
        //    Anim.SetBool("RightMom", false);
        //    Anim.SetBool("LeftMom", true);
        //    Anim.SetBool("Walk", true);
        //}
        //if (gameObject.transform.rotation.eulerAngles.y <= Forward.y)
        //{
        //    Anim.SetBool("RightMom", false);
        //    Anim.SetBool("LeftMom", false);
        //    Anim.SetBool("Walk", true);
        //}
        //else
        //{
        //    Anim.SetBool("RightMom", false);
        //    Anim.SetBool("LeftMom", false);
        //    Anim.SetBool("Walk", false);
        //}
    }
}
