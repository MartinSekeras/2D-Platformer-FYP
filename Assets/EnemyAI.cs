using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    public int health;
    public int damage;

    public void takeDamage()
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
