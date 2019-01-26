using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRoom
{
    static int[] Doors;
    // Use this for initialization
    public static void start ()
    {
        Doors = new int[10];
        Doors[0] = 0;
        Doors[1] = 100;
        Doors[2] = 200;
        Doors[3] = 300;
        Doors[4] = 400;
        Doors[5] = 500;

    }
	public static int Switcheroo(int i)
    {
        return Doors[i];
    }
    public static int MumKnows(int i)
    {
        return i * 100;
    }
	// Update is called once per frame
	public static int PenisInCamera(int j)
    {
        return j;
    }
}
