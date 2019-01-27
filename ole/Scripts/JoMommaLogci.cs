using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoMommaLogci : MonoBehaviour
{

    Vector3 Right;
    Vector3 Left;
    Vector3 Forward;
    public Animator Anim;
    public MommaScript mm;
    float savedzAxis;
    float savedxAxis;
    float zAxis;
    float xAxis;
    float xDistance;
    float zDistance;
    Vector3 savedTrans;
    Vector3 myTrans;
    int xAx;
    int zAx;
   public  Light lights;
    public GameObject target;
    public Vector3 targetv3;
    RaycastHit hit;
    float dist;
    void Start()
    {
        dist = Vector3.Distance(target.transform.position, gameObject.transform.position);
        Anim = gameObject.GetComponent<Animator>();
       // lights = gameObject.GetComponent<Light>();
        //Right = new Vector3(0, 90, 0);
        //Left = new Vector3(0, 90, 0);
        //Forward = new Vector3(0, 90, 0);
        savedxAxis = gameObject.transform.position.x;
        savedzAxis = gameObject.transform.position.z;
        savedTrans = gameObject.transform.position;
    }

    void Update()
    {
        xAxis = gameObject.transform.position.x;
        zAxis = gameObject.transform.position.z;
        myTrans = gameObject.transform.position;
        xDistance = 0;
        zDistance = 0;
        if (myTrans != savedTrans)
        {
            xDistance = Vector3.Distance(new Vector3(xAxis, 0, 0), new Vector3(savedxAxis, 0, 0));
            zDistance = Vector3.Distance(new Vector3(0, 0, zAxis), new Vector3(0, 0, savedzAxis));
           
            if (xDistance>zDistance)
            {
               
                
                if (xAxis > savedxAxis)
                {
                   
                    
                    Anim.SetBool("RightMom", true);
                    Anim.SetBool("LeftMom", false);
                    Anim.SetBool("Walk", true);
                    Anim.SetBool("Up", false);
                    if(xAx>=3)
                    {
                        lights.transform.rotation = Quaternion.Euler(44.448f, 90, 0);
                        targetv3 = gameObject.transform.position + new Vector3(dist, 0, 0);
                    }

                    xAx += 1;
                    if (zAx >= 3)
                    {
                        zAx = 1;
                    }
                    else zAx = 0;
                }
                else
                {
                   
                    Anim.SetBool("RightMom", false);
                    Anim.SetBool("LeftMom", true);
                    Anim.SetBool("Walk", true);
                    Anim.SetBool("Up", false);
                    if (xAx >= 3)
                    {
                        lights.transform.rotation = Quaternion.Euler(44.448f, -90, 0);
                        targetv3 = gameObject.transform.position + new Vector3(-dist, 0, 0);
                    }
                    
                    xAx += 1;
                    if (zAx >= 3)
                    {
                        zAx = 1;
                    }
                    else zAx = 0;
                }

            }
            if (zDistance>xDistance)
            {
                

                
                    if (zAxis < savedzAxis)
                    {
                        Anim.SetBool("RightMom", false);
                        Anim.SetBool("LeftMom", false);
                        Anim.SetBool("Walk", true);
                        Anim.SetBool("Up", false);
                    if (zAx>=3)
                    {
                        lights.transform.rotation = Quaternion.Euler(44.448f, -180, 0);
                        targetv3 = gameObject.transform.position + new Vector3(0, 0, -dist);
                    }


                    if (xAx >= 3)
                    {
                        xAx = 1;
                    }
                    else xAx = 0;
                    zAx += 1; ;
                }
                    else
                    {
                        Anim.SetBool("RightMom", false);
                        Anim.SetBool("LeftMom", false);
                        Anim.SetBool("Walk", true);
                        Anim.SetBool("Up", true);
                    if(zAx>=3)
                    {
                        lights.transform.rotation = Quaternion.Euler(44.448f, 0, 0);
                        targetv3 = gameObject.transform.position + new Vector3(0, 0, dist);
                    }


                    if (xAx >= 3)
                    {
                        xAx = 1;
                    }
                    else xAx = 0;
                    zAx += 1; ;

                }
                }

            
            savedTrans = myTrans;
            savedxAxis = xAxis;
            savedzAxis = zAxis;
        }
        Vector3 heading = gameObject.transform.position- target.transform.position;
        float distance = heading.magnitude;
        Vector3 direction = heading / distance;
        if(Physics.Raycast(gameObject.transform.position, direction,out  hit,30f))
        {
            if(hit.collider.tag=="PLayer")
            { Debug.Log("got yaa"); }
        }
<<<<<<< HEAD

        



=======
        else
        {
            Anim.SetBool("RightMom", false);
            Anim.SetBool("LeftMom", false);
            Anim.SetBool("Walk", false);
            Anim.SetBool("Up", false);

        }
>>>>>>> 31f250caa5574bfc596ebe65d757e2c610e2bf46
    }

}
