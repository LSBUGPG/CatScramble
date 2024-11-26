using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    public Transform target;
    public float maxDistance = 10;

    void Start()
    {
        
    }

    bool CanSeeTarget()
    {
        Ray toTarget = new(transform.position, target.position);
        return !Physics.Raycast(toTarget, maxDistance);
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);
        if (CanSeeTarget())
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime);        
        }
    }
}
