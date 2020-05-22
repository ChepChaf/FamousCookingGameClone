using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Transform _itemPosition;
    GameObject _grabing;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && _grabing != null)
        {
            Drop();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Ground" || other.tag == "Player" || _grabing != null)
            return;

        // Debug.Log("Colidded with: " + other.ToString());
        if (other.tag == "Pickable")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Take(other.gameObject);
            }
        }

        if (other.tag == "Shelf")
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                IActionable actionable = other.GetComponent(typeof(IActionable)) as IActionable;
                actionable.Action();
            }
        }
    }

    public void Take(GameObject item)
    {
        IPickable pickable = item.GetComponent(typeof(IPickable)) as IPickable;
        pickable.Grab(_itemPosition);

        _grabing = item;
    }

    public void Drop()
    {
        IPickable pickable = _grabing.GetComponent(typeof(IPickable)) as IPickable;
        pickable.Drop();

        _grabing = null;
    }
}
