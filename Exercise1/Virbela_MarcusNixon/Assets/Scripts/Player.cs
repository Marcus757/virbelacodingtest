using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public HighlightableObject FindClosest(HighlightableObject[] highlightableObjects)
    {
        HighlightableObject cloestHighlightableObject = null;
        float shortestDistance = Mathf.Infinity;

        foreach (var highlightableObject in highlightableObjects)
        {
            float tempDistance = Vector3.Distance(highlightableObject.transform.position, transform.position);
            if (tempDistance <= shortestDistance)
            {
                shortestDistance = tempDistance;
                cloestHighlightableObject = highlightableObject;
            }
        }

        return cloestHighlightableObject;
    }
}
