using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMode : MonoBehaviour
{
    public bool isGhost;
    public Collider2D colliderOfWall;
    public GameObject normalSees;
    public GameObject gostSees;

    void Start()
    {
        colliderOfWall = GetComponent<Collider2D>();
        isGhost = false;
        gostSees.SetActive (false);
        normalSees.SetActive (true);
        
    }

    void Update()
    {
        Color c = isGhost ? Color.white : Color.red;
        string tag = isGhost ? "Ghost" : "Player";
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<SpriteRenderer>().color = c;  
            isGhost = !isGhost;
            
            gostSees.SetActive (!isGhost);
            normalSees.SetActive (isGhost);

            //gameObject.GetComponent<Controll>().enabled = isGhost;
            //пусть призрак тоже бегает, ему можно будет увел. скорость
            gameObject.tag = tag;
            colliderOfWall.isTrigger = !isGhost;
        }
    }
}
