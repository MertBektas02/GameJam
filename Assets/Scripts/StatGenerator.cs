using NUnit.Framework.Interfaces;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatGenerator : MonoBehaviour
{

    public Button sendHero;
    private HeroStats heroStats;
    
    private WorldStats worldStats;
    public TextMeshProUGUI heroTestStatText;
    public TextMeshProUGUI worldText;

    

    
    void Start()
    {
        heroStats= new HeroStats();
        worldStats=new WorldStats();
        //PrintStats();
        heroTestStatText.text=$"test Stat:{heroStats.testStat}\n"+ $"Stamina:{heroStats.heroStamina}";
        worldText.text=$"test stat:{worldStats.testStat}";

        sendHero.onClick.AddListener(OnButtonCheck);


        
    }
    
//   public void PrintStats()
//     {
//         Debug.Log("test stat"+heroStats.testStat);
//         Debug.Log("test stat"+worldStats.testStat);

//     }

    void OnButtonCheck()
    {
        if(worldStats.testStat<=heroStats.testStat)
        {
            Debug.Log("Hero bu gezegenin üstesinden gelebilir");
        }
        else{Debug.Log("Hero öldü");}
        heroStats.testStat=Random.Range(1,21);
        worldStats.testStat=Random.Range(1,21);
        UpdateText();

    }

    public void UpdateText()
    {
        heroTestStatText.text=$"HERO test Stat:{heroStats.testStat}\n"+ $"Stamina:{heroStats.heroStamina}";
        worldText.text=$"WORLD test stat:{worldStats.testStat}";
    }
    
    
}
