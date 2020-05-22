using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelf : Container, IActionable
{
    public virtual void Action()
    {
        Debug.Log("Called Action on: " + this.ToString());
    }
}
