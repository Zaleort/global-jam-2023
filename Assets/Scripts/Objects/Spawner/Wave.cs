using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave
{
    public Lane[] lanes;
    public Enemy[] enemyPool;
    public int quantity;
    public float baseSpeed;

    public Wave(Lane[] lanes, Enemy[] enemies, int quantity, float baseSpeed)
    {
        this.enemyPool = enemies;
        this.baseSpeed = baseSpeed;
        this.quantity = quantity;
        this.lanes = lanes;
    }
}
