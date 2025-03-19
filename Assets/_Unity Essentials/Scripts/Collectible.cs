using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float RotatingSpeed;
    public GameObject onCollectEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, RotatingSpeed, 0);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        { 


    // Destroy the collectible
    Destroy(gameObject);
    Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
    }
}
