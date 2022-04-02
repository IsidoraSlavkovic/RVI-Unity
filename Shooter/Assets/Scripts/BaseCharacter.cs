using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : MonoBehaviour, IDamageable
{
    [SerializeField] private int health = 9;
    public int Health { get { return health; } }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        Debug.Log(health);
        Debug.Log(damage);
        health -= damage;
        Debug.Log(health);
        if(health <= 0)
        {
            Die();
        }
    }

}