using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueExample : MonoBehaviour
{
    //public Queue<string> isimler = new Queue<string>();

    [SerializeField] private GameObject[] players;

    public Queue<GameObject> playerQueue = new Queue<GameObject>();

    private void Awake()
    {
        //isimler.Enqueue("Ahmet");
        //isimler.Enqueue("Emre");
        //isimler.Enqueue("Yildiz");

        for(int i = 0; i < players.Length; i++) 
        {
            playerQueue.Enqueue(players[i]);
        }

    }

    private void Start()
    {
        //print(isimler.Dequeue());
        //print(isimler.Dequeue());
        //print(isimler.Dequeue());

        //if (isimler.Count > 0)
        //    print(isimler.Dequeue());

        int queueCount = playerQueue.Count;

        for (int i = 0; i < queueCount; i++)
        {
            GameObject obj = playerQueue.Dequeue();

            print(obj.name);
        }
    }
}
