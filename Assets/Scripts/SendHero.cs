using UnityEngine;
using UnityEngine.UI;

public class SendHero : MonoBehaviour
{
    [SerializeField]private HeroStats2 heroStats2;
    [SerializeField]private PlanetStats planetStats;
    [SerializeField]private StatGenerator2 statGenerator2;
    [SerializeField]private UIManager uIManager;
    public Button button;
     private string currentPlanetTag = "";


   
    void Start()
    {
        button.onClick.AddListener(OnButtonCheck);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Planet1") || other.CompareTag("Planet2") || other.CompareTag("Planet3") || other.CompareTag("Planet4"))
        {
            currentPlanetTag = other.tag;  // İçeri giren gezegenin tag'ini kaydet
            Debug.Log($"Gezegen algılandı: {currentPlanetTag}");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == currentPlanetTag)
        {
            currentPlanetTag = "";  // Çıkınca tag sıfırlanır
            Debug.Log("Gezegen trigger'dan çıktı!");
        }
    }
    void OnButtonCheck()
    {
        //debug fileri
        Debug.Log($"planetStats: {planetStats}");
    Debug.Log($"heroStats2: {heroStats2}");

    if (planetStats == null)
    {
        Debug.LogError("planetStats NULL! Inspector'dan atanmış mı kontrol et!");
        return;
    }
    if (heroStats2 == null)
    {
        Debug.LogError("heroStats2 NULL! Inspector'dan atanmış mı kontrol et!");
        return;
    }

    if (planetStats.planet1TestStat <= heroStats2.testStat)
    {
        Debug.Log("Hero bu gezegenin üstesinden gelebilir!");
    }
    else
    {
        Debug.Log("Hero öldü!");
    }
    //debug ifleri

        if (currentPlanetTag == "Planet1" && planetStats.planet1TestStat <= heroStats2.testStat)
        {
            Debug.Log("Hero bu gezegenin üstesinden gelebilir!");
        }
        else if (currentPlanetTag == "Planet2" && planetStats.planet2TestStat <= heroStats2.testStat)
        {
            Debug.Log("Hero bu gezegenin üstesinden gelebilir!");
        }
        else if (currentPlanetTag == "Planet3" && planetStats.planet3TestStat <= heroStats2.testStat)
        {
            Debug.Log("Hero bu gezegenin üstesinden gelebilir!");
        }
        else if (currentPlanetTag == "Planet4" && planetStats.planet4TestStat <= heroStats2.testStat)
        {
            Debug.Log("Hero bu gezegenin üstesinden gelebilir!");
        }
        else
        {
            Debug.Log("Hero öldü!");
        }
        uIManager.UpdateText();

        // Yeni stat üret
        heroStats2.testStat = StatGenerator2.GenerateStat();
        planetStats.planet1TestStat=StatGenerator2.GenerateStat();
        planetStats.planet2TestStat=StatGenerator2.GenerateStat();
        planetStats.planet3TestStat=StatGenerator2.GenerateStat();
        planetStats.planet4TestStat=StatGenerator2.GenerateStat();
        uIManager.UpdateText();

    }
}
