using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] RoleEntity boss;

    [SerializeField] RoleEntity enmey;

    Vector3 CenterPos = new Vector3(0, 0, 0);
    Vector3  radius;

    void Awake()
    {
        radius = boss.transform.position - CenterPos;
    }

    void Update()
    {
        float dt = Time.deltaTime;
        // RoleDamain.Move(enmey, boss.transform.position, dt);

        radius = Quaternion.AngleAxis(180*dt,Vector3.forward)*radius;
        boss.transform.position = CenterPos + radius;
    }
}
