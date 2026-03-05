using UnityEngine;

/// <summary>
/// Script que controla el movimiento del jugador
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    // Velocidad de movimiento del jugador
    public float speed;

    // Update se ejecuta una vez por frame
    private void Update()
    {
        // Comprobamos qué tecla se está pulsando para el movimiento del jugador
        if (Input.GetKey(KeyCode.W))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.linearVelocity = new Vector3(0, 0, speed * 0.5f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.linearVelocity = new Vector3(0, 0, -speed * 0.5f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.linearVelocity = new Vector3(-speed * 0.5f, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.linearVelocity = new Vector3(speed * 0.5f, 0, 0);
        }

    }
}