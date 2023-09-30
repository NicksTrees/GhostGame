
using System;
using UnityEngine;

public class Water2 : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player2")
        {
            Console.WriteLine("dfsfd");
            PlayerPrefs.SetString("Die2", "True");
        }
    }
}
