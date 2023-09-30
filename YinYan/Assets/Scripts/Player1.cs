
using System.Collections;
using UnityEngine;
public class Player1 : MonoBehaviour
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
    //UI
    public Menu M;

    void Awake()
    {
        moveUp = KeyCode.UpArrow; moveDown = KeyCode.DownArrow;
        moveLeft = KeyCode.LeftArrow; moveRight = KeyCode.RightArrow;

        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        PlayerPrefs.SetString("Die", "False");
    }
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal2");
        jumpImput = Input.GetAxis("Vertical2");
         // изменение позиции по x
        if (Input.GetKey(moveRight))
        {
            GetComponent<SpriteRenderer>().flipX = false;
            //anim.Play("VincentRun");
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }
        else if (Input.GetKey(moveLeft))
        {
            GetComponent<SpriteRenderer>().flipX = true;
            //anim.Play("VincentRun");
            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(moveUp) && Mathf.Abs(rb.velocity.y) < 0.01f)
        {;
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
        else if (PlayerPrefs.GetString("Die") == "True")
        {
            Animate(3);
            Death(3);
            M.Die();
        }
        else if (PlayerPrefs.GetString("Die") != "True")
        {
            Animate(0);
        }
    }

    private void Animate(int n)
    {
        anim.SetInteger("William", n);
       
    }
    public IEnumerator Death(float seconds = 0)
    {
        yield return new WaitForSeconds(seconds);
        
    }

}
