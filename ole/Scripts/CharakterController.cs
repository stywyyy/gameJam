using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharakterController : MonoBehaviour
{
    public Animator Anim;
    [Range(0.5f,1)]public float speed = 0.5f;
    // Use this for initialization
    void Start ()
    {
        Anim = gameObject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(Anim.GetBool("Walk") == true)
        {
            if (Anim.GetBool("Left") == true)
            {
                gameObject.transform.position += new Vector3(-speed, 0, 0);
            }
            else if(Anim.GetBool("Up") == true)
            {
                gameObject.transform.position += new Vector3(0, 0, speed);
            }
            else if (Anim.GetBool("Right") == true)
            {
                gameObject.transform.position += new Vector3(speed, 0, 0);
            }
            else
            {
                gameObject.transform.position += new Vector3(0, 0, -speed);
            }
        }
		if (Input.GetKeyDown("w")|| Input.GetKeyDown("up"))
        {
            Anim.SetBool("Right", false);
            Anim.SetBool("Left", false);
            Anim.SetBool("Up", true);
            Anim.SetBool("Walk", true);
        }
        if (Input.GetKeyUp("w") || Input.GetKeyUp("up"))
        {
            Anim.SetBool("Right", false);
            Anim.SetBool("Left", false);
            Anim.SetBool("Up", false);
            Anim.SetBool("Walk", false);
        }
        if (Input.GetKeyDown("d") || Input.GetKeyDown("right"))
        {
            Anim.SetBool("Right", true);
            Anim.SetBool("Left", false);
            Anim.SetBool("Up", false);
            Anim.SetBool("Walk", true);
        }
        if (Input.GetKeyUp("d") || Input.GetKeyUp("right"))
        {
            Anim.SetBool("Right", false);
            Anim.SetBool("Left", false);
            Anim.SetBool("Up", false);
            Anim.SetBool("Walk", false);
        }
        if (Input.GetKeyDown("s") || Input.GetKeyDown("down"))
        {
            Anim.SetBool("Right", false);
            Anim.SetBool("Left", false);
            Anim.SetBool("Up", false);
            Anim.SetBool("Walk", true);
        }
        if (Input.GetKeyUp("s") || Input.GetKeyUp("down"))
        {
            Anim.SetBool("Right", false);
            Anim.SetBool("Left", false);
            Anim.SetBool("Up", false);
            Anim.SetBool("Walk", false);
        }
        if (Input.GetKeyDown("a") || Input.GetKeyDown("left"))
        {
            Anim.SetBool("Right", false);
            Anim.SetBool("Left", true);
            Anim.SetBool("Up", false);
            Anim.SetBool("Walk", true);
        }
        if (Input.GetKeyUp("a") || Input.GetKeyUp("left"))
        {
            Anim.SetBool("Right", false);
            Anim.SetBool("Left", false);
            Anim.SetBool("Up", false);
            Anim.SetBool("Walk", false);
        }
    }
}
