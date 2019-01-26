using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Path  {
    public List<GameObject> Nodes = new List<GameObject>();
    public int ID;
    public List<int> IdNextPathes = new List<int>();
}
