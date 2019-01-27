using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mbDoor : MonoBehaviour
{
    Animator m_Animator;
    public GameObject go;
    public GameObject activecam;
    public int DoorId;
    bool bolyan;
    public int ebene;
    public Cams c;
    string PENIS;
    public MommaScript Mom;

    // Use this for initialization
    void Start ()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        SwitchRoom.start();
    }
    bool open = false;
    bool enter = false;
    bool walk = false;
	// Update is called once per frame
	void Update () {
        c.text.text = PENIS;
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
        PENIS = "press Space to Enter";
        if (col.tag=="Player")
            enter = true;
    }
    void OnTriggerStay(Collider col)
    {
        if (Input.GetKeyUp("space"))
        {
            Debug.Log(c.cams[DoorId]);
            if (DoorId != 0)
            {
                go.transform.position += new Vector3(0, 0, SwitchRoom.Switcheroo(DoorId));
                Debug.Log(SwitchRoom.Switcheroo(DoorId));
                c.cams[DoorId].SetActive(true);
                //
                bolyan = true;
            }
            else if (DoorId == 0)
            {
                go.transform.position -= new Vector3(0, 0, SwitchRoom.Switcheroo(ebene));
                Debug.Log(-SwitchRoom.Switcheroo(DoorId));
                c.cams[0].SetActive(true);
                bolyan = true;
            }
        }
    }
    void OnTriggerExit(Collider col)
    {

        PENIS = "";
        if (bolyan == true)
        {
            activecam.SetActive(false);
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
