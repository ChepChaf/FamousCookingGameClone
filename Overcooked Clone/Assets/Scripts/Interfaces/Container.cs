using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour, IContainer
{
    protected List<IPickable> items = new List<IPickable>();
    public void Place(IPickable item)
    {
        Debug.Log("Placing " + item.ToString() + " into " + this.ToString());
        this.items.Add(item);
    }

    public void Take(IPickable item)
    {
        this.items.Remove(item);
    }
}
