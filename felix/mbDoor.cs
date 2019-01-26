﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mbDoor : MonoBehaviour {
    Animator m_Animator;

    // Use this for initialization
    void Start () {
        m_Animator = gameObject.GetComponent<Animator>();
    }
    bool open = false;
    bool enter = false;
    bool walk = false;
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.W))
            walk = true;
        if (Input.GetKeyUp(KeyCode.W))
            walk = false;

       
            Debug.Log("open");
            if (open == false && enter == true && walk ==true)
            {
                open = true;
            }
            
            animate();



     
       
	}
    void animate()
    {
        if (open == false)
        {
            m_Animator.SetBool("doorOpen", false);

        }
        else 
        {
            m_Animator.SetBool("doorOpen", true);

        }
    }
    void OnTriggerEnter(Collider col)
    {
        
        if(col.tag=="Player")
            enter = true;
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
            if(open == true && enter == true && walk == true)
            {
                open = false;
                enter = false;
            }
            

    }
}