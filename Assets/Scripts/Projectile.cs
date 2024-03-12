using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] 
public class Projectile : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float forceAmount = 15.0f;
    public GameObject explosionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        Vector3 forceDirection = transform.forward;

        rigidbody.AddForce(forceDirection * forceAmount, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    { //instatiate explosion prefab at projectile position
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            // destory projectile
            Destroy(gameObject);
        
    }
}
