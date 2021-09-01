using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private HighlightableObject[] highlightableObjects;
    [SerializeField] private Player player;
    [SerializeField] private HighlightableObject previousHighlightableObject;
    
    // Start is called before the first frame update
    void Start()
    {
        highlightableObjects = GameObject.FindObjectsOfType<HighlightableObject>();
    }

    // Update is called once per frame
    void Update()
    {
        HighlightableObject highlightableObject = player.FindClosest(highlightableObjects);
        SwapColor(highlightableObject);
    }

    private void SwapColor(HighlightableObject highlightableObject)
    {
        if (System.Object.ReferenceEquals(highlightableObject, previousHighlightableObject))
            return;
        
        highlightableObject.SwapColor(highlightableObject.HighlightColor);

        if (previousHighlightableObject != null)
            previousHighlightableObject.SwapColor(previousHighlightableObject.BaseColor);
        
        previousHighlightableObject = highlightableObject;
    }
}
