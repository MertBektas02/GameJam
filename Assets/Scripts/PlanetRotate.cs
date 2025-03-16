using UnityEngine;

public class PlanetRotate : MonoBehaviour
{
     public float rotationSpeed = 100f; // Döndürme hızı
     private float mouseX;

    void Update()
    {
        // Sağ & Sol Ok Tuşlarıyla Döndürme
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }

        if (Input.GetMouseButton(0)) // Sol tıklama ile döndürme
        {
            mouseX = Input.GetAxis("Mouse X");
            transform.Rotate(Vector3.up, -mouseX * rotationSpeed);
        }
    }
}
