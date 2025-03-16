using System.Collections.Generic;
using UnityEngine;

public class PlanetSpawner : MonoBehaviour
{
    public GameObject planetPrefab;  // PlanetGenerator bileþeni olan prefab
    public int planetCount = 5;      // Çemberde kaç gezegen olacaðýný belirle
    public float radius = 5f;        // Çemberin yarýçapý
    public Vector3 center = Vector3.zero; // Çemberin merkez noktasý


    private List<GameObject> planets = new List<GameObject>();
    private void Start()
    {
        SpawnPlanets();
    }

    public void SpawnPlanets()
    {
        if (planetPrefab == null)
        {
            Debug.LogWarning("PlanetPrefab atanmadý!");
            return;
        }

        // Önce var olan gezegenleri temizle
        Debug.Log("Var olan gezegenler siliniyor...");
        foreach (GameObject planet in planets)
        {
            Destroy(planet);
        }
        planets.Clear();

        // Gezegenleri çember þeklinde yerleþtir
        Debug.Log("Gezegenler oluþturuluyor...");
        for (int i = 0; i < planetCount; i++)
        {
            float angle = i * Mathf.PI * 2 / planetCount; // Çemberin çevresinde eþit aralýk
            Vector3 position = center + new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;

            GameObject newPlanet = Instantiate(planetPrefab, position, Quaternion.identity);
            // PlanetGenerator scriptine eriþ ve GeneratePlanet() çaðýr
            PlanetGenerator generator = newPlanet.GetComponent<PlanetGenerator>();
            if (generator != null)
            {
                generator.GeneratePlanet();
            }
            else
            {
                Debug.LogWarning("PlanetGenerator bileþeni bulunamadý!");
            }
            planets.Add(newPlanet);
            Debug.Log("Gezegen oluþturuldu: " + newPlanet.name);
        }
    }
}
