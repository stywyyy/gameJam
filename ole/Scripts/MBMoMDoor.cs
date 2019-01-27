using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MBMoMDoor : MonoBehaviour
{
    public Cams c;
    //public MommaScript mom;
    float count = 0;
    float i;
    float f = 0;
    int rnd = 0;
    int check = 0;
    MommaScript mom;
    void Update()
    {
        int rand = Random.Range(0, 3);
        f = Time.deltaTime;
        count += f;
        i = Random.Range(10, 30);
        //Debug.Log(c.Moms.Count);
        if (count > i && check == 0)
        {
            for (int i = 0; i < c.Moms.Count; i++)
            {
                Debug.Log(c.Moms[i].activeSelf);
                if (c.Moms[i].activeSelf == true)
                {
                    mom = c.Moms[i].GetComponent<MommaScript>();
                    Debug.Log(rand);
                    check = rand;
                    Debug.Log(check);
                    //Debug.Log(mom.agent.remainingDistance);
                    mom.agent.SetDestination(c.Doors[rand].transform.position);
                    count = 0;
                }
            }
        }
        if (check != 0)
        {
                if (mom.agent.remainingDistance < 20)
                {
                //    if (rnd != 0)
                //    {
                //        rnd = 0;
                //    }
                //    else if (rnd == 0)
                //    {
                        //rnd = Random.Range(1, 3);
                //    }
                    for (int i = 0; i < c.Moms.Count; i++)
                    {
                        c.Moms[i].SetActive(false);
                    }
                    c.Moms[check].SetActive(true);
                    Debug.Log(check);
                    count = 0;
                }
            check = 0;
        }
        
    }
}

