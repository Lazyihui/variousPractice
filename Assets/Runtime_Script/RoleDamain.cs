using System;
using System.Collections.Generic;
using UnityEngine;

public static class RoleDamain
{
    public static void Move(RoleEntity enemy,Vector3 centerPos ,float dt)
    {
        enemy.transform.RotateAround(centerPos, new Vector3(0,0,1), 60*dt);
    }
}