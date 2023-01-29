using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{
    void Start()
    {
        // Navigate to Castle
        GameObject castle = GameObject.Find("Castle");
        if (castle)
            GetComponent<NavMeshAgent>().destination = castle.transform.position;
    }
    void OnTriggerEnter(Collider co)
    {
        // If castle then deal Damage, destroy self
        if (co.name == "Castle")
        {
            co.GetComponentInChildren<health>().decrease();
            Destroy(gameObject);
        }
    }
}
