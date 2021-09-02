using System;
using UnityEngine;

// Created an abstract class because Item and Bot share the same
// properties and behavior. Considered using an interface, but realized
// creating an interface didn't really add value because Item and Bot
// would have had the same implementation. If the functionality was slightly
// different for SwapColor in Item and Bot, creating an interface would
// have been the path.
public abstract class HighlightableObject : MonoBehaviour
{
    // Wanted private fields to prevent modification from outside the class, but also wanted the fields to be accessible in subclasses
    // so made them protected. Added SerializeField annotation to make visible to designer that wants to modify the colors
    // at edit time.
    [SerializeField] protected Color baseColor;
    [SerializeField] protected Color highlightColor;

    public void Start()
    {
        // Set the base color of the object as soon as the app starts
        GetComponent<Renderer>().material.color = baseColor;
    }

    // Properties that can be used outside the class that essentially are getter methods for underlying property
    public Color BaseColor => baseColor;
    public Color HighlightColor => highlightColor;
    
    // Thought about creating 2 methods, one for changing the material's color to the base color
    // and the other for changing the material's color to the highlight color. Decided to keep it simple
    // with just one method and just pass in the color we want as a parameter.
    public void SwapColor(Color color)
    {
        GetComponent<Renderer>().material.color = color;
    }
}
