using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow1 : MonoBehaviour
{
    public Transform target; // Referencia al transform del personaje que la cámara seguirá
    public float smoothSpeed = 0.125f; // Velocidad de suavizado del seguimiento de la cámara
    public Vector3 offset; // Distancia entre la cámara y el personaje
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            // Calcula la posición a la que la cámara debería moverse
            Vector3 desiredPosition = target.position + offset;
            // Interpola suavemente entre la posición actual de la cámara y la posición deseada
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            // Establece la posición de la cámara
            transform.position = smoothedPosition;
        }
    }
}
