using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Enemy
{
    private void Start()
    {
        Taunt();
    }

    override protected void Attack()
    {

    }
    public void Flee()
    {
        
    }

    protected override void Taunt()
    {
        base.Taunt();
        m_health += 10;
    }
}
