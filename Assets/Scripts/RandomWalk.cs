using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomWalk : MonoBehaviour
{
    public float mRange = 25.0f;
    Vector2 lastPos;
    NavMeshAgent mAgent;
    Vector2 randomPos;
    void Start()
    {
        mAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (mAgent.pathPending || mAgent.remainingDistance > 0.1f)
            return;
        randomPos = UnityEngine.Random.insideUnitCircle * mRange;
        if (randomPos == lastPos)
            randomPos = UnityEngine.Random.insideUnitCircle * mRange;
        mAgent.destination = new Vector3(randomPos.x, 0, randomPos.y);
    }
}