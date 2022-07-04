using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievement : MonoBehaviour
{
    public GameObject ourWindow;
    public Text pointsText;
    public Text achievementText;
    public int points;
    public bool scored1Points, scored2Points, scored3Points, scored4Points, scored5Points;
    public bool pointsAchievementShowed;

    private void Update()
    {
        if(points >= 1)
        {
            scored1Points = true;
        }

        if (points >= 2)
        {
            scored2Points = true;
        }

        if (points >= 3)
        {
            scored3Points = true;
        }

        if (points >= 4)
        {
            scored4Points = true;
        }

        if (points >= 5)
        {
            scored5Points = true;
        }

        if(scored1Points == true && pointsAchievementShowed == false)
        {
            OpenWindow();
            achievementText.text = "you scored 1 points";
            pointsAchievementShowed = true;
        }

    }

    public void OpenWindow()
    {
        ourWindow.SetActive(true);
    }

    public void CloseWindow()
    {
        ourWindow.SetActive(false);
    }
}