
using UnityEngine;

public class Door1: MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player2")
        {
            animator.Play("Opendoor1");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player2")
        {
            animator.Play("CloseDoor2");
        }
    }
}
