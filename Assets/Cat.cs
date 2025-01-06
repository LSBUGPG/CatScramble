using UnityEngine;

public class Cat : MonoBehaviour
{
    public Transform target;
    public float maxDistance = 10;

    public GameScore score;
    public LayerMask layerMask;

    public void CollectCoin()
    {
        score.CollectCoin();
    }

    bool CanSeeTarget()
    {
        Ray toTarget = new(transform.position, target.position - transform.position);
        return !Physics.Raycast(toTarget, maxDistance, layerMask);
    }

    void Update()
    {
        if (CanSeeTarget())
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime);        
        }
    }
}
