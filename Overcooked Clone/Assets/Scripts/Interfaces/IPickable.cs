using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPickable
{
    void Grab(Transform transform);
    void Drop();
}
