using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int NumberofGems { get; private set; }

    public void GemCollected()
    {
        NumberofGems++;
    }
}
