using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonicSpawn : MonoBehaviour
{
    public GameObject sonic;

    public void WowSonicReal()
    {
        Instantiate(sonic, new Vector3(10.4f, 2.16f, 3.14f), Quaternion.Euler(0,90,0));
    }
}
