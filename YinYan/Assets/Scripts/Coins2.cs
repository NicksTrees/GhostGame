
using UnityEngine;

public class Coins2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player2")
        {
            Destroy(gameObject);
        }
    }
}
