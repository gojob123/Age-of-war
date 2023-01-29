using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitStatus : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private float health;
    [SerializeField] private float damage;
    void Start()
    {
        health = maxHealth;
    }
    private void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
