using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickableContainer : Pickable, IContainer
{
    List<IPickable> items = new List<IPickable>();

    public void Place(IPickable item)
    {
        Debug.Log("Placing " + item.ToString() + " in " + this.ToString());
        this.items.Add(item);
    }

    public void Take(IPickable item)
    {
        this.items.Remove(item);
    }
}
