using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField, Range(0.1f, 10f)]
    float moveSpeed;

    [SerializeField, Range(0f, 10f)]
    float minDistance;
    UnityEngine.AI.NavMeshAgent navMeshAgent;

    void Awake() {
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        if(Attack)
        {
            navMeshAgent.destination = GameManager.instance.Player.transform.position;
            //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            transform.LookAt(GameManager.instance.Player.transform);
        }
    }

    bool Attack
    {
        get => Vector3.Distance(this.transform.position, GameManager.instance.Player.transform.position) <= minDistance;

    }
}
