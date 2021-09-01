using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Item[] items;
    [SerializeField] private Player player;
    
    // Start is called before the first frame update
    void Start()
    {
        items = GameObject.FindObjectsOfType<Item>();
    }

    // Update is called once per frame
    void Update()
    {
        Item item = player.FindClosest(items);
        item.SwapColor();
    }
}
