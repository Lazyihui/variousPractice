using System;
using System.Collections.Generic;
using UnityEngine;

public static class RoleDamain
{
    public static void Move(RoleEntity enemy,Vector3 centerPos ,float dt)
    {
        float distance = Vector3.Distance(enemy.transform.position, centerPos);
        Debug.Log("distance:"+distance);
        float angle = 1/180*distance;
        enemy.transform.RotateAround(centerPos, new Vector3(0,0,1), distance*180 * dt);
    }
}