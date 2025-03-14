using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatGenerator : MonoBehaviour
{
    private HeroStats heroStats;
    private WorldStats worldStats;
    public TextMeshProUGUI heroTestStatText;
    public TextMeshProUGUI worldText;

    
    void Start()
    {
        heroStats= new HeroStats();
        worldStats=new WorldStats();
        PrintStats();
        heroTestStatText.text=$"test Stat:{heroStats.testStat}\n"+ $"Stamina:{heroStats.heroStamina}";
        worldText.text=$"test stat:{worldStats.testStat}";


        
    }
    
  public void PrintStats()
    {
        Debug.Log("test stat"+heroStats.testStat);
        Debug.Log("test stat"+worldStats.testStat);

    }
}
