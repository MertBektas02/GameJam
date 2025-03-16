using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Text Elementleri")]
     public TextMeshProUGUI planet1Text;
     public TextMeshProUGUI planet2Text;
     public TextMeshProUGUI planet3Text;
     public TextMeshProUGUI planet4Text;
     public TextMeshProUGUI HeroStatText;
    
    public TextMeshProUGUI[] planetTexts; // Tüm gezegen textleri
    private Camera mainCamera;

    private HeroStats2 heroStats2;
    private PlanetStats planetStats;

    void Start()
    {
        heroStats2=new HeroStats2();
        planetStats=new PlanetStats();
        mainCamera = Camera.main; // Ana kamerayı al
        UpdateText();
    }

    void Update()
    {
        foreach (var text in planetTexts)
        {
            if (text != null)
            {
                text.transform.rotation = Quaternion.LookRotation(text.transform.position - mainCamera.transform.position);
            }
        }
    }

    public void UpdateText()
    {
        planet1Text.text=$"Planet Name Test stat:{planetStats.planet1TestStat}";
        planet2Text.text=$"Planet Name Test stat:{planetStats.planet2TestStat}";
        planet3Text.text=$"Planet Name Test stat:{planetStats.planet3TestStat}";
        planet4Text.text=$"Planet Name Test stat:{planetStats.planet4TestStat}";
        HeroStatText.text=$"Hero Stats:{heroStats2.testStat}";
        
    }
}
