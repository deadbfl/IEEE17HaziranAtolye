using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] players;

    public Transform[] spawnPoints;

    public Queue<Transform> spawnQueue = new Queue<Transform>();

    private void Awake()
    {
        for(int i = 0; i < spawnPoints.Length; i++)
        {
            spawnQueue.Enqueue(spawnPoints[i]);
        }
    }

    private void Start()
    {
        SpawnPlayer();
    }

    public void SpawnPlayer()
    {
        for (int i = 0; i < players.Length; i++)
        {
            Transform availablePoint = spawnQueue.Dequeue();

            players[i].position = availablePoint.position;
        }
    }
}
