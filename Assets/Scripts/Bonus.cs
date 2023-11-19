using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] float moveSpeed;

    public int getHealth()
    {
        return health;
    }

    public float getSpeed()
    {
        return moveSpeed;
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
