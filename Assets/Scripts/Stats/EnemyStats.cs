﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : CharacterStats
{
    public override void Die()
    {
        base.Die();

        //death animation / ragdoll

        //add loot
        Destroy(gameObject);
    }
}