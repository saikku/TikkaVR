using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartFlight : MonoBehaviour
{
    public GameObject dart;
    private ControllerGrabObject script;
    public bool InFlight = false;

    void Start()
    {

    }

    void Update()
    {
        //dart.transform.forward = Vector3.Slerp(transform.forward, dart.GetComponent<Rigidbody>().velocity.normalized, Time.deltaTime * 15);
        //if (InFlight == true)
        //{
            if (!dart.GetComponent<Rigidbody>().isKinematic)
            {
                dart.GetComponent<Rigidbody>().rotation = Quaternion.LookRotation(dart.GetComponent<Rigidbody>().velocity);
                Debug.DrawRay(dart.transform.position, dart.GetComponent<Rigidbody>().velocity, Color.red, 5);
            }
        //}
    }

    void OnCollisionEnter(Collision collision)
    {
        dart.GetComponent<Rigidbody>().isKinematic = true;
    }

    void OnMouseDown()
    {
        dart.GetComponent<Rigidbody>().useGravity = true;
        dart.GetComponent<Rigidbody>().isKinematic = false;
        dart.GetComponent<Rigidbody>().velocity = new Vector3(0, 3, 6);
       // InFlight = true;
    }
}
