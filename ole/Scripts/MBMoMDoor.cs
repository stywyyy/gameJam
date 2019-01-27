using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MBMoMDoor : MonoBehaviour
{
    public Cams c;
    float count = 0;
    float i;
    float f = 0;
    void Update()
    {
        f = Time.deltaTime;
        count += f;
        i = Random.Range(10, 30);
        int rnd = Random.Range(0, 3);
        Debug.Log(c.Moms.Count);
        if (count > i)
        {
            Debug.Log(c.Moms.Count);
            for (int i = 0; i < c.Moms.Count; i++)
            {
                c.Moms[i].SetActive(false);
            }
            c.Moms[rnd].SetActive(true);
            Debug.Log(rnd);
            count = 0;
        }
        
    }
}

