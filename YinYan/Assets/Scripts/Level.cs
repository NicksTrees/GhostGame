using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    int a = 0;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if(a == 0)
        {
            On();
        } else
        {
            Off();
        }
    }
    public void On()
    {
        spriteRenderer.sprite = Resources.Load<Sprite>("Assets/Images/IMG_1237.PNG");
        a = 1;
    }
    public void Off()
    {
        spriteRenderer.sprite = Resources.Load<Sprite>("Assets/Images/IMG_1252_0");
        a = 0;
    }
}
