using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreScript : MonoBehaviour
{
    public float current_score;

    public TextMeshProUGUI score_text;

    private float starting_score = 0000f;
    // Start is called before the first frame update
    void Start()
    {
        current_score = starting_score;
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = current_score.ToString("0000");
    }
}
