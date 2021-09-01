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

    public Item FindClosest(Item[] items)
    {
        Item closestItem = null;
        float shortestDistance = Mathf.Infinity;

        foreach (var go in items)
        {
            float tempDistance = Vector3.Distance(go.transform.position, transform.position);
            if (tempDistance <= shortestDistance)
            {
                shortestDistance = tempDistance;
                closestItem = go;
            }
        }

        return closestItem;
    }
}
