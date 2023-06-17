using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int sayi;

    private void Awake()
    {
        instance = this;
    }

    public void PrintSayi()
    {
        print(sayi);
    }
}
