using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRoom : MonoBehaviour
{
    int[] Doors;
    // Use this for initialization
    void Start ()
    {
        Doors = new int[10];
        Doors[0] = 0;
        Doors[1] = 100;
        Doors[2] = 200;

    }
	public int Switcheroo(int i)
    {
        return Doors[i];
    }
	// Update is called once per frame
	void Update ()
    {
		
	}
}
