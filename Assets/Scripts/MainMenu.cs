using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public Button button1;
    public Button button2;
    public Button button3;

    public int buttonIndex = 0;

    public void PlayGame()
    {
        SceneManager.LoadScene("LevelScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            buttonIndex++;
            if (buttonIndex > 2)
            {
                buttonIndex = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            buttonIndex--;
            if (buttonIndex < 0)
            {
                buttonIndex = 2;
            }
        }

        //Update Highlighted Button
        if (buttonIndex == 0)
        {
            button1.Select();
        }
        if (buttonIndex == 1)
        {
            button2.Select();
        }
        if (buttonIndex == 2)
        {
            button3.Select();
        }
    }
}
