using System;
using UnityEngine;

public abstract class HighlightableObject : MonoBehaviour
{
    [SerializeField] protected Color baseColor;
    [SerializeField] protected Color highlightColor;

    public void Start()
    {
        GetComponent<Renderer>().material.color = baseColor;
    }

    public Color BaseColor => baseColor;
    public Color HighlightColor => highlightColor;
    
    public void SwapColor(Color color)
    {
        GetComponent<Renderer>().material.color = color;
    }
}
