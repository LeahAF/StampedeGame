using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    public float speed = 40f;
    private float lowerBound = -10f;
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
