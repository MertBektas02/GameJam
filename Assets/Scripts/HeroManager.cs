using UnityEngine;

public class HeroManager : MonoBehaviour
{
    private HeroStats heroStats;

   [SerializeField] private GameObject selectedHero=null;

    void Update()
    {
        //heroyu seçme ve kontrol etme
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider.CompareTag("Hero"))
                {
                    if(selectedHero!=null)
                    {
                        DeselectHero();
                    }
                    SelectHero(hit.collider.gameObject); 
                }
            }
            else
            {
                if(selectedHero!=null)
                {
                    DeselectHero(); 
                }
            }
        }
        //heroyu seçme ve kontrol etme
    }

    //Click ile hero seçme ve rengini değiştirme testi. RayCast ile seçeceğim
    void SelectHero(GameObject hero)
   {
    selectedHero=hero;
    Renderer heroRenderer=selectedHero.GetComponent<Renderer>();
    if(heroRenderer!=null)
    {
        heroRenderer.material.color=Color.green;
        Debug.Log("hero selected");
    }
   }
   void DeselectHero()
   {
    if(selectedHero!=null)//hero seçili halde gelirse null hatası almamak için
    {
     Renderer heroRenderer=selectedHero.GetComponent<Renderer>();
     if(heroRenderer!=null)
     {
         heroRenderer.material.color=Color.white;
         Debug.Log("Hero DeSelected");
     }
     selectedHero=null;
    }
   }
    //Click ile hero seçme ve rengini değiştirme testi. RayCast ile seçeceğim

}
