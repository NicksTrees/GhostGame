
using UnityEngine;

public class Button : MonoBehaviour
{
    public SpriteRenderer buttonImage;
    public Sprite On;
    public Sprite Off;
    public Line line;
    public LineY lineY;
    public void OnCollisionEnter2D(Collision2D collision)
    {
       buttonImage.sprite = On;
        lineY.OperateDoor();
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        buttonImage.sprite = Off;
        lineY.OperateDoor();
    }
}
