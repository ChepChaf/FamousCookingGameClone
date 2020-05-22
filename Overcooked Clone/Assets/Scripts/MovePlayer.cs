using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]
public class MovePlayer : MonoBehaviour
{
    CharacterController _characterController;

    [SerializeField]
    float speed = 5f;

    void Start()
    {
        this._characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get Movement direction
        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(xMove, .0f, zMove);

        // Rotate Character
        if (movementDirection != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(movementDirection);

        _characterController.SimpleMove(movementDirection * speed);
    }
}
