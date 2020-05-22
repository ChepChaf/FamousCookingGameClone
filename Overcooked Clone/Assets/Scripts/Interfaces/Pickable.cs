using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Pickable : MonoBehaviour, IPickable
{
    Rigidbody _rigidBody;
    [SerializeField]
    bool dropped = false;
    [SerializeField]
    bool inContainer = false;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    public virtual void Drop()
    {
        Debug.Log("Dropping: " + this.ToString());
        this.transform.parent = null;
        _rigidBody.useGravity = true;
        dropped = true;
    }

    public virtual void Grab(Transform transform)
    {
        Debug.Log("Grab: " + this.ToString());
        this.transform.position = transform.position;
        this.transform.parent = transform;
        
        _rigidBody.useGravity = false;
        dropped = false;
    }

    private void OnTriggerStay(Collider other)
    {
        IContainer container = other.GetComponent(typeof(IContainer)) as IContainer;

        if (container != null)
        {
            Debug.Log("Container not null");
            Debug.Log("Dropped: " + dropped);
            if (dropped)
            {
                Debug.Log("Dropped in contaner");
                if (!inContainer)
                {
                    container.Place(this);
                    inContainer = true;
                    dropped = true;
                }
            }
            else if (!dropped && other.tag == "Player")
            {
                Debug.Log("Grabing by player");
                if (inContainer)
                {
                    container.Take(this);
                    inContainer = false;

                    other.GetComponent<PlayerController>().Take(this.gameObject);
                }
            }
        }
    }
}
