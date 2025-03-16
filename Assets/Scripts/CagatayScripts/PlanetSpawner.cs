using System.Collections.Generic;
using UnityEngine;

public class PlanetSpawner : MonoBehaviour
{
    public GameObject planetPrefab;  // PlanetGenerator bile�eni olan prefab
    public int planetCount = 5;      // �emberde ka� gezegen olaca��n� belirle
    public float radius = 5f;        // �emberin yar��ap�
    public Vector3 center = Vector3.zero; // �emberin merkez noktas�


    private List<GameObject> planets = new List<GameObject>();
    private void Start()
    {
        SpawnPlanets();
    }

    public void SpawnPlanets()
    {
        if (planetPrefab == null)
        {
            Debug.LogWarning("PlanetPrefab atanmad�!");
            return;
        }

        // �nce var olan gezegenleri temizle
        Debug.Log("Var olan gezegenler siliniyor...");
        foreach (GameObject planet in planets)
        {
            Destroy(planet);
        }
        planets.Clear();

        // Gezegenleri �ember �eklinde yerle�tir
        Debug.Log("Gezegenler olu�turuluyor...");
        for (int i = 0; i < planetCount; i++)
        {
            float angle = i * Mathf.PI * 2 / planetCount; // �emberin �evresinde e�it aral�k
            Vector3 position = center + new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;

            GameObject newPlanet = Instantiate(planetPrefab, position, Quaternion.identity);
            // PlanetGenerator scriptine eri� ve GeneratePlanet() �a��r
            PlanetGenerator generator = newPlanet.GetComponent<PlanetGenerator>();
            if (generator != null)
            {
                generator.GeneratePlanet();
            }
            else
            {
                Debug.LogWarning("PlanetGenerator bile�eni bulunamad�!");
            }
            planets.Add(newPlanet);
            Debug.Log("Gezegen olu�turuldu: " + newPlanet.name);
        }
    }
}
