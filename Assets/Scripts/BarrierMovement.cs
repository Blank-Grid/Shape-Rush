using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierMovement : MonoBehaviour {
    public float speed; // 障碍物移动速度
    public bool isReady = false; // 是否准备移动

    void Update()
    {
        if (isReady)
            transform.position += Vector3.down * speed * Time.deltaTime;
    }
}
