using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour {
    public Vector3 offset;
    private Transform player;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update() {
        transform.position = player.position + offset;
    }
}
