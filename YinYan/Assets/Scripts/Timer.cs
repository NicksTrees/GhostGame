
using TMPro;
using UnityEngine;
using System;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI time;
    public float timeInSecondsP = 0f;
    private static int minutsP;
    private static int secondsP;
    private static string mins;
    private static string secs; 

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("TimeOver", 0);
        timeInSecondsP += Time.deltaTime;
        secondsP = (int)(timeInSecondsP % 60);
        minutsP = (int)(timeInSecondsP / 60);

        Console.WriteLine(secondsP + "  " + minutsP);

        mins = minutsP + "";
        secs = secondsP + "";

        if (minutsP < 10)
        {
            mins = "0" + mins;
        } 
        if(secondsP < 10)
        {
            secs = "0" + secs; 
        }
        time.text = mins + ":" + secs;

    }
}
