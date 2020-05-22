using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public interface IContainer
{
    void Place(IPickable item);
    void Take(IPickable item);
}
