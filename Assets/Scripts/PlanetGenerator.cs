using UnityEngine;

public class PlanetGenerator : MonoBehaviour
{
    public Material planetMaterial; // material that will be assigned to the planet.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GeneratePlanet();
    }

    void GeneratePlanet()
    {
        float randomSize = Random.Range(0.5f, 2f); // Random size
        transform.localScale = Vector3.one * randomSize; // changing the size of planet according to randomSize.

        if(planetMaterial != null)
        {
            Color randomColor = new Color(Random.value, Random.value, Random.value); // random color
            planetMaterial.SetColor("_BaseColor", randomColor); // signing the random color to the planetMaterial.

            planetMaterial.SetFloat("_NoiseScale", Random.Range(10f, 100f));
            planetMaterial.SetFloat("_NoiseStrength", Random.Range(0.1f, 1f));
            planetMaterial.SetFloat("_FresnelIntensity", Random.Range(0.5f, 3f));
            GetComponent<MeshRenderer>().material = planetMaterial; // signing planetMaterial to the obj meshrenderer.
        }

        transform.rotation = Random.rotation; // randomizing the rotation of the obj.
    }

    
}
