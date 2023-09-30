
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Line : MonoBehaviour
{
    public bool open;
    Vector3 closePosition;
    public float duration = 1;
    public void Start()
    {
        closePosition = transform.position;
    }

    public void OperateDoor(int direction, float length)
    {
        StopAllCoroutines();
        if (!open)
        {
            Vector3 openPosition = closePosition + new Vector3(length * direction,0,0);
            StartCoroutine(MoveDoor(openPosition));
        }
        else
        {
            StartCoroutine(MoveDoor(closePosition));
        }
        open = !open;
    }
    IEnumerator MoveDoor(Vector3 targetPosition)
    {
        float timeElapsed = 0;
        Vector3 startPosition = transform.position;
        while (timeElapsed < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, timeElapsed / duration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
    }
    public void OperateDoor(int direction)
    {
        StopAllCoroutines();
        if (!open)
        {
            Vector3 openPosition = closePosition + new Vector3(2 * direction, 0, 0);
            StartCoroutine(MoveDoor(openPosition));
        }
        else
        {
            StartCoroutine(MoveDoor(closePosition));
        }
        open = !open;
    }
}
