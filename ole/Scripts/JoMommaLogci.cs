using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoMommaLogci : MonoBehaviour {

    Vector3 Right;
    Vector3 Left;
    Vector3 Forward;
    public Animator Anim;
    public MommaScript mm;
    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
        //Right = new Vector3(0, 90, 0);
        //Left = new Vector3(0, 90, 0);
        //Forward = new Vector3(0, 90, 0);
    }

    void Update()
    {
        if (gameObject.transform.position.z >= mm.goal.transform.position.z)
        {
            Anim.SetBool("RightMom", true);
            Anim.SetBool("LeftMom", false);
            Anim.SetBool("Walk", true);
            Anim.SetBool("Up", false);
        }
        else if (gameObject.transform.position.z <= mm.goal.transform.position.z)
        {
            Anim.SetBool("RightMom", false);
            Anim.SetBool("LeftMom", true);
            Anim.SetBool("Walk", true);
            Anim.SetBool("Up", false);
        }
        else if (gameObject.transform.position.x >= mm.goal.transform.position.x)
        {
            Anim.SetBool("RightMom", false);
            Anim.SetBool("LeftMom", false);
            Anim.SetBool("Walk", true);
            Anim.SetBool("Up", false);
        }
        else if (gameObject.transform.position.x <= mm.goal.transform.position.x)
        {
            Anim.SetBool("RightMom", false);
            Anim.SetBool("LeftMom", false);
            Anim.SetBool("Walk", false);
            Anim.SetBool("Up", true);
        }
    }
}
