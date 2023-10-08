using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMode : MonoBehaviour
{
    public static bool isGhost;
    public GameObject Walls;
    public GameObject ONM;
    public GameObject OGM;
    public GameObject Ghost;

    void Start()
    {
        Ghost.SetActive (false);
        isGhost = false;
        Walls.SetActive (true);
        OGM.SetActive (false);
        ONM.SetActive (true);
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && !isGhost)
        {
            Ghost.SetActive (true);
            isGhost = true;
            Walls.SetActive (false);
            OGM.SetActive (true);
            ONM.SetActive (false);
            gameObject.GetComponent<Controll>().enabled = false;
        }
        if(Input.GetKey(KeyCode.Space) && isGhost)
        {
            Ghost.SetActive (false);
            isGhost = false;
            Walls.SetActive (true);
            OGM.SetActive (false);
            ONM.SetActive (true);
            gameObject.GetComponent<Controll>().enabled = true;
        }
    }
}
