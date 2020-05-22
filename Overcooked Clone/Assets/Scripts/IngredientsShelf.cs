using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientsShelf : Shelf
{
    public override void Action()
    {
        Debug.Log("Called Action on IngredientsShelf");
    }
}
