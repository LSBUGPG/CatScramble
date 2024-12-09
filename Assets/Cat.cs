using System;
using TMPro;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public Transform target;
    public float maxDistance = 10;
    public TMP_Text coinCounter;

    int coins = 0;

    public void AddCoin()
    {
        coins++;
        coinCounter.text = $"Coins: {coins}";
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
