using UnityEngine;

public class PlanetSelector : MonoBehaviour
{
    public Camera mainCamera;
    public Transform focusPoint; // Kameran�n �n�ndeki nokta
    private GameObject selectedPlanet;
    private Vector3 previousPlanetPosition; // �nceki gezegenin eski konumunu saklayacak

    void Start()
    {
        selectedPlanet = null;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Sol t�klama
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Planet")) // Gezegen mi?
                {
                    SelectPlanet(hit.collider.gameObject);
                }
            }
        }
    }

    void SelectPlanet(GameObject planet)
    {
        if (selectedPlanet != null)
        {
            // E�er daha �nce bir gezegen se�ildiyse, eski gezegenin yerine d�nmesini sa�la
            StartCoroutine(MoveToPosition(selectedPlanet.transform, previousPlanetPosition, 1f));
            //selectedPlanet.transform.position = previousPlanetPosition;
        }
        selectedPlanet = planet;
        previousPlanetPosition = planet.transform.position; // Yeni gezegenin eski konumunu sakla
        StartCoroutine(MoveToPosition(planet.transform, focusPoint.position, 1f));
        //planet.transform.position = focusPoint.position; // Eski Kameran�n �n�ne getir kodu (MoveToPosition)
    }

    public void RandomizeSelectedPlanet()
    {
        if (selectedPlanet != null)
        {
            PlanetGenerator generator = selectedPlanet.GetComponent<PlanetGenerator>();
            if (generator != null)
            {
                generator.GeneratePlanet();
            }
        }
    }

    System.Collections.IEnumerator MoveToPosition(Transform obj, Vector3 target, float duration)
    {
        float elapsed = 0;
        Vector3 startPos = obj.position;

        while (elapsed < duration)
        {
            obj.position = Vector3.Lerp(startPos, target, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        obj.position = target;
    }
}
