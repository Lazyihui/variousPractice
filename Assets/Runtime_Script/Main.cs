using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] RoleEntity boss;

    [SerializeField] RoleEntity enmey;

    void Awake()
    {

    }

    void Update()
    {
        float dt = Time.deltaTime;
        RoleDamain.Move(enmey, boss.transform.position, dt);
    }
}
