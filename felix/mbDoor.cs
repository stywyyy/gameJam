using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mbDoor : MonoBehaviour
{
    Animator m_Animator;
    public GameObject go;
    public GameObject activecam;
    public List<GameObject> cams;
    public int DoorId;
    bool bolyan;
    public Vector3 Max;

    // Use this for initialization
    void Start () {
        m_Animator = gameObject.GetComponent<Animator>();
        SwitchRoom.start();
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
    void OnTriggerStay(Collider col)
    {
        if (Input.GetKeyUp("space"))
        {
            if (go.transform.position.z >= Max.z)
            {
                go.transform.position -= new Vector3(0, 0, SwitchRoom.Switcheroo(DoorId));
            }
            else
                go.transform.position += new Vector3(0, 0, SwitchRoom.Switcheroo(DoorId));
            cams[DoorId].SetActive(true);
            bolyan = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (bolyan == true)
        {
            activecam.SetActive(false);
            activecam = cams[DoorId];
            bolyan = false;
        }
        if (col.tag == "Player")
            if(open == true && enter == true && walk == true)
            {
                open = false;
                enter = false;
            }
            

    }
}
