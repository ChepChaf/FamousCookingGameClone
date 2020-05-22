using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dish : PickableContainer, IPickable
{
    public override string ToString()
    {
        return "Dish";
    }
}
