using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoppingTable : Shelf
{
    public override void Action()
    {
        Debug.Log("Called Action on Chopping Table");
        if (this.items.Count > 0)
        {
            Debug.Log("Chopping: " + this.items[0]);
        }
    }
}
