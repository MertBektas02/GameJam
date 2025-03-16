// using Unity.Mathematics;
// using UnityEngine;

// public class StatDubber : MonoBehaviour
// {
//         private HeroStats heroStats; 
//         private WorldStats worldStats;
//         StatGenerator statGenerator;

//     void Start()
//     {
//         statGenerator = FindObjectOfType<StatGenerator>();
//         heroStats=GetHeroStats();
//     }


//     void OnTriggerEnter(Collider other)
//     {
//         if(other.CompareTag("Hero"))
//         {
//             Multiply(heroStats);
//             statGenerator.UpdateText();
//             Debug.Log("is trigger working");
//         }
//     }

//     public int Multiply(HeroStats heroStats)
//     {
//        return heroStats.testStat*2; 
//     }

//     public HeroStats GetHeroStats()
//     {
//         return heroStats;
//     }
// }
