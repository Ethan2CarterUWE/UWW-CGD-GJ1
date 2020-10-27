using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public addScore score;
    public float current_time = 0;
    float starting_time = 60; 
    public TextMeshProUGUI countdown_text;

    // Start is called before the first frame update
    void Start()
    {
        current_time = starting_time;
    }

    // Update is called once per frame
    void Update()
    {
        current_time -= 1 * Time.deltaTime;
        countdown_text.text = current_time.ToString("0");

        if (current_time <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
