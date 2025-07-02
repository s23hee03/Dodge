using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    public Rigidbody bulletRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletRigidbody.linearVelocity = transform.forward * speed;
        Destroy(gameObject, 3f); // Destroy the bullet after 2 seconds
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (playerController != null)
            {
                // Assuming PlayerController has a method to handle bullet hit
                playerController.Die();
            }
        }
    }
    // Update is called once per frame
}
