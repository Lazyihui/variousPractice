using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
    [SerializeField] RoleEntity boss;

    [SerializeField] RoleEntity enmey;

    Vector3 center = new Vector3(0,0,0);
    

    void Awake() {
        
    }
    void Update() {
        float dt = Time.deltaTime;

        AroundRotare(dt,180,center,enmey.transform.position);

    }



    public void AroundRotare(float dt,float round,Vector3 centerPos,Vector3 RolePos) {
        

        center = boss.transform.position;
        Vector3 radius = RolePos - centerPos;


        radius = Quaternion.AngleAxis(round * dt, Vector3.forward) * radius;
        enmey.transform.position = center + radius;

    }


}
