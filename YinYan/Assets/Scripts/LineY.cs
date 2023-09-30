using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class LineY : MonoBehaviour
{
    public bool open;
    Vector3 closePosition;
    public float duration = 1;
    public void Start()
    {
        closePosition = transform.position;
    }

    public void OperateDoor(float height)
    {
        StopAllCoroutines();
        if (!open)
        {
            Vector3 openPosition = closePosition + new Vector3(0, height, 0);
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
    public void OperateDoor()
    {
        StopAllCoroutines();
        if (!open)
        {
            Vector3 openPosition = closePosition + new Vector3(0, 2, 0);
            StartCoroutine(MoveDoor(openPosition));
        }
        else
        {
            StartCoroutine(MoveDoor(closePosition));
        }
        open = !open;
    }
}
