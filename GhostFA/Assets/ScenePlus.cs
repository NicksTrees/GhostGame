using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePlus : MonoBehaviour
{
    public int sceneid;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Finish"))
        {
            SceneManager.LoadScene(sceneid);
        }
    }
}
