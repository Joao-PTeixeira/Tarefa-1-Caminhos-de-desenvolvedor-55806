using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float RotatingSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(0, RotatingSpeed, 0);

    }
}
