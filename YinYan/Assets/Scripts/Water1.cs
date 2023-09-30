
using UnityEngine;

public class Water1 : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player1")
        {
            PlayerPrefs.SetString("Die", "True");
        }
    }
}
