using UnityEngine;

// Created GameManager as central place to control the flow of the app.  
public class GameManager : MonoBehaviour
{
    // To track the Items and Bots, we use an array of type highlightableObjects.
    [SerializeField] private HighlightableObject[] highlightableObjects;
    
    // We also need to track the player so that we can use its position to calculate the distance between
    // the player and the Items or Bots
    [SerializeField] private Player player;
    
    // Decided to track the object that was highlighted on the previous frame
    [SerializeField] private HighlightableObject previousHighlightableObject;
    
    // Start is called before the first frame update
    void Start()
    {
        // Finding all Items or Bots in the scene. Called from Start and nowhere near the performance
        // hit if decided to call from Update on every frame
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
        // Uses System.Object.ReferenceEquals() is a good way to determine if 2 objects in a 
        // scene are truly the same exact object
        if (System.Object.ReferenceEquals(highlightableObject, previousHighlightableObject))
            return;
        
        highlightableObject.SwapColor(highlightableObject.HighlightColor);

        // The first time we swap color, previousHighlightableObject will be null
        if (previousHighlightableObject != null)
            previousHighlightableObject.SwapColor(previousHighlightableObject.BaseColor);
        
        // Capture the object that just had it color swapped
        previousHighlightableObject = highlightableObject;
    }
}
