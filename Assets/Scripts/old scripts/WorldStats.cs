using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class WorldStats 
{


    public int worldStamina{get; private set;}
    public int testStat{ get;  set;}

    public WorldStats()
    {
        testStat=Random.Range(1,21);
    }
    

}
