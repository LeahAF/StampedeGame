using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public float speed = 40f;
    private float topBound = 30;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
    }
}
