using UnityEngine;

public class PlanetStats
{
    public int planet1TestStat;
    public int planet2TestStat;
    public int planet3TestStat;
    public int planet4TestStat;

    public PlanetStats()
    {
        planet1TestStat=StatGenerator2.GenerateStat();
        planet2TestStat=StatGenerator2.GenerateStat();
        planet3TestStat=StatGenerator2.GenerateStat();
        planet4TestStat=StatGenerator2.GenerateStat();
        
    }
}
