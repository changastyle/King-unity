using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.AI;

public class followLogic : MonoBehaviour
{
    public GameObject target;

    private NavMeshAgent navMesh;

    public float distanceRemaining = 0f;



    // Start is called before the first frame update
    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
        navMesh.destination = target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {   
        distanceRemaining = navMesh.remainingDistance;
    }
}
