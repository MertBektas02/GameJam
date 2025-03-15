using UnityEngine;

public class PlanetGenerator : MonoBehaviour
{
    public Material baseMaterial;

    public void GeneratePlanet()
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        if (renderer == null)
        {
            Debug.LogWarning("MeshRenderer bulunamadý!");
            return;
        }

        Material newMaterial = new Material(baseMaterial); // Materyali kopyala, böylece deðiþiklik tüm gezegenlere yayýlmaz
        newMaterial.SetColor("_BaseColor", new Color(Random.value, Random.value, Random.value));
        newMaterial.SetFloat("_NoiseScale", Random.Range(10f, 100f));
        newMaterial.SetFloat("_NoiseStrength", Random.Range(0.1f, 1f));
        newMaterial.SetFloat("_FresnelIntensity", Random.Range(0.5f, 3f));

        renderer.material = newMaterial;

        float randomSize = Random.Range(0.5f, 2f);
        transform.localScale = Vector3.one * randomSize;
    }
}
