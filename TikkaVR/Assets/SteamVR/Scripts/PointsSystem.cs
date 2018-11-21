using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsSystem : MonoBehaviour
{

    private int points = 0;

    void Start()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Pisteet: " + points);

        if (other.transform.tag == "one")
        {
            points += 1;
        }

        if (other.transform.tag == "three")
        {
            points += 3;
        }

        if (other.transform.tag == "six")
        {
            points += 6;
        }

        if (other.transform.tag == "ten")
        {
            points += 10;
        }
    }
}
