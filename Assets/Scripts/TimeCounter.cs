using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCounter : MonoBehaviour
{
    public float time = 60f;
    public Text timeText;

    void Update()
    {
        time -= Time.deltaTime;

        int minutes = Mathf.FloorToInt(time / 60F);
        int seconds = Mathf.FloorToInt(time - minutes * 60);

        string text = string.Format("{0:00}:{1:00}", minutes, seconds);
        timeText.text = text;

        if (time <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
