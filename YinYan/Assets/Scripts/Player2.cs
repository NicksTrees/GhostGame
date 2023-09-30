
using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    private KeyCode moveRight;
    private KeyCode moveLeft;
    private KeyCode moveUp;
    private KeyCode moveDown;
    public float speed = 2f;

    // jump
    private Rigidbody2D rb;
    public float jumpForce = 5f;
    //public bool isGround = true;

    //animation
    private float moveInput;
    private float jumpImput;
    public Animator anim;
    public Menu M;

    void Awake()
    {
       moveUp = KeyCode.W; moveDown = KeyCode.S;
       moveLeft = KeyCode.A; moveRight = KeyCode.D;

        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        PlayerPrefs.SetString("Die2", "False");

    }
    private void Start()
    {
        PlayerPrefs.SetString("Die2", "False");
    }
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");
        jumpImput = Input.GetAxis("Vertical");
        // изменение позиции по x
        if (Input.GetKey(moveRight))
        {
            GetComponent<SpriteRenderer>().flipX = false;
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }
        else if (Input.GetKey(moveLeft))
        {
            GetComponent<SpriteRenderer>().flipX = true;
            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(moveUp) && Mathf.Abs(rb.velocity.y) < 0.01f)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
        if (moveInput != 0 && jumpImput == 0)
        {
            Animate(1);
        }
        else if (moveInput != 0 && jumpImput != 0)
        {
            Animate(2);
        }
         else if (PlayerPrefs.GetString("Die2") == "True")
        {
            Animate(3);
            Death(3);
            M.Die();
        }
        else if (PlayerPrefs.GetString("Die2") != "True")
        {
            Animate(0);
        }
    }

    private void Animate(int n)
    {
        anim.SetInteger("Vincent", n);
    }
    public IEnumerator Death(float seconds = 0)
    {
        yield return new WaitForSeconds(seconds);
    }
}
