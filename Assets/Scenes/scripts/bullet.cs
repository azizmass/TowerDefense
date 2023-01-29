using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Speed
    public float speed = 10;

    // Target (set by Tower)
    public Transform target;

    void FixedUpdate()
    {
        if (target)
        {
            // Fly towards the target
            Vector3 dir = target.position - transform.position;
            GetComponent<Rigidbody>().velocity = dir.normalized * speed;
        }
        else
        {
            // Otherwise destroy self
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider co)
    {
        health health = co.GetComponentInChildren<health>();
        if (health)
        {
            health.decrease();
            Destroy(gameObject);
        }
    }
}
