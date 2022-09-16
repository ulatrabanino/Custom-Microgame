using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{   
    [SerializeField]
    private AudioClip bling = null;
    public AudioSource source = null;
    public SonicSpawn sonic;

    private void Start()
    {
        if(source == null)
        {
            Debug.Log("Audio source is NULL");
        }
        else
        {
            source.clip = bling;
        }
    }
    public int NumberofGems { get; private set; }

    public void GemCollected()
    {
        NumberofGems++;
        source.Play();
        if(NumberofGems == 6)
        {
            sonic.WowSonicReal();
        }
    }
}
