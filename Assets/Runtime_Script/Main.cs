using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
    [SerializeField] RoleEntity boss;

    [SerializeField] RoleEntity enmey;

    Vector3 CenterPos = new Vector3(0, 0, 0);
    Vector3 radius;

    void Awake() {
        CenterPos = boss.transform.position;
        radius = enmey.transform.position - CenterPos;
    }

    public Vector3 Rotate(Vector3 centerPos, Vector3 rolePos/*要移动物体的pos*/, float round/*以每秒多少度的速度绕半径向量旋转*/, float dt) {
        Vector3 radius = rolePos - centerPos;
        radius = Quaternion.AngleAxis(round * dt, Vector3.forward) * radius;
        return centerPos + radius;
    }

    void Update() {
        float dt = Time.deltaTime;
        // RoleDamain.Move(enmey, boss.transform.position, dt);
        CenterPos = boss.transform.position;

        radius = Quaternion.AngleAxis(180*dt,Vector3.forward)*radius;
        enmey.transform.position = CenterPos + radius;
        // enmey.transform.position = Rotate(boss.transform.position, enmey.transform.position, 180, dt);

    }
}
