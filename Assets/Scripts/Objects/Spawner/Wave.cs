using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave
{
    public int level = 1;
    public Lane[] lanes;
    public Enemy[] enemyPool;
    public int quantity;
    public float baseSpeed;

    public Wave(int level, Lane[] lanes, Enemy[] enemies, int quantity, float baseSpeed)
    {
        this.level = level;
        this.enemyPool = enemies;
        this.baseSpeed = baseSpeed;
        this.quantity = quantity;
        this.lanes = lanes;
    }

    public Wave Clone()
    {
        return new Wave(level, lanes, enemyPool, quantity, baseSpeed);
    }
}
