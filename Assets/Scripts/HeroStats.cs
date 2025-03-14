using NUnit.Framework.Internal;
using UnityEngine;

public class HeroStats
{
    // [Header("Hero Stats")]

    // public int heroTestStat=1;
    // public int heroStamina=1;
    // public int heroIntelligence=1;
    // public int heroWisdom=1;
    // public int heroStrength=1;
    // public int herCharisma=1;
    // public int heroDexterity=1;


    public int testStat{get; private set;}
    public int heroStamina{get; private set;}
    public int heroIntelligence{get; private set;}
    public int heroWisdom{get; private set;}
    public int heroStrength{get; private set;}
    public int heroCharisma{get; private set;}
    public int heroDexterity{get; private set;}


    public HeroStats()
    {
        testStat=Random.Range(1,21);
        heroStamina=Random.Range(1,21);
        heroIntelligence=Random.Range(1,21);
        heroWisdom=Random.Range(1,21);
        
        
    }

    public void PrintStats()
    {
        Debug.Log("test stat"+testStat);
    }

}
