using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(PlayerMovement))]
public class PlayerInput : MonoBehaviour
{
    PlayerMovement playerMovement;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            playerMovement.Move(Input.mousePosition);
    }
}
