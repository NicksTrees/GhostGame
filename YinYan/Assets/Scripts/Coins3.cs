
using UnityEngine;

public class Coins3 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
            Destroy(gameObject);
        
    }
}
