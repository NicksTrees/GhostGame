
using UnityEngine;

public class Coins1 : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player1")
        {
            Destroy(gameObject);
        }
    }
}
