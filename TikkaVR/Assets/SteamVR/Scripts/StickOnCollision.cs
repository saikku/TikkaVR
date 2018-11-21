using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickOnCollision : MonoBehaviour {

    public Rigidbody rBody;

    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider col)
    { 
        if (col.gameObject.transform.name == "Stand")
        {
            Debug.Log("Kiinni!");
            rBody.isKinematic = true;

        }
    }
}
