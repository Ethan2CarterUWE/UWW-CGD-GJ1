using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addScore : MonoBehaviour
{
    public GameObject passenger;
    public scoreScript score_script;

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("TriggerPassenger");
            score_script.current_score += 100;
            Destroy(gameObject);
        }
    }
}
