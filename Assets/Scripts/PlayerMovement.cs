using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent (typeof (NavMeshAgent))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private LayerMask layer;

    private NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void Move(Vector3 positionToGo)
    {
        Ray ray = Camera.main.ScreenPointToRay(positionToGo);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100, layer))
        {
            agent.SetDestination(hit.point);
        }
    }
}
