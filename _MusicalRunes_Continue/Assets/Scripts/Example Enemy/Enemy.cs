using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public float m_health;

    protected float m_damage;

    protected abstract void Attack();

    protected void Patrol()
    {
        //Patroll
    }

    protected virtual void Taunt()
    {
        //Taunt the Player
    }
}
