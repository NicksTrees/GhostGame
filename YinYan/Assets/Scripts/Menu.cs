
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private bool musicFlag = false;
    public AudioSource audioSource;

    public GameObject diePanel;
    public Image button;
    public Sprite On;
    public Sprite Off;
    public Animator windowDeath;

    public void Music()
    {
        button.overrideSprite = musicFlag ?
            On
            : Off;
        if (musicFlag == false)
        { 
            audioSource.Stop();
        } 
        else
        {
            audioSource.Play();
        }
        musicFlag = !musicFlag;
    }

    public void Die()
    {
        diePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        windowDeath.SetBool("Diss2", false);
        windowDeath.SetBool("Diss", true);
    }

    public IEnumerator Death2(float seconds = 0)
    {
        yield return new WaitForSeconds(seconds);
    }
}
