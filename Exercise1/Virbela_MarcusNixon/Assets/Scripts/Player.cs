using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Method takes an array of highlightable objects, iterates through the collection, calculates the distance
    // from the player to each object and returns the closest object. Uses the abstract class HighlightableObject
    // in order to iterate through objects of different types, such as Item and Bot. Used Mathf.Infinity as a 
    // placeholder for shortestDistance because every value calculated from the Vector3.Distance() function should be 
    // shorter.
    public HighlightableObject FindClosest(HighlightableObject[] highlightableObjects)
    {
        HighlightableObject cloestHighlightableObject = null;
        float shortestDistance = Mathf.Infinity;

        foreach (var highlightableObject in highlightableObjects)
        {
            float tempDistance = Vector3.Distance(highlightableObject.transform.position, transform.position);
            if (tempDistance < shortestDistance)
            {
                shortestDistance = tempDistance;
                cloestHighlightableObject = highlightableObject;
            }
        }

        return cloestHighlightableObject;
    }
}
