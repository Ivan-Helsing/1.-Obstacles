using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Language")]
public class Languages : ScriptableObject
{
    [Header("Language")]
    [SerializeField] string language = "English";


    [Header("Hint Label")] [TextArea(1, 6)]
    [SerializeField] string findButtonHint;


    [Header("Moving Explanation")]
    [SerializeField] string movingKeys = "WASD";
    [SerializeField] string movingExplanationText = " - use for moving.";
    [SerializeField] string shiftKey = "Shift";
    [SerializeField] string shiftExplanationText = " - use for sprint.";
    [SerializeField] string spaceBar = "Space";
    [SerializeField] string spaceExplanationText = " - use for jumping.";
    [SerializeField] string escapeKey = "Escape";
    [SerializeField] string escapeExplanationKey = " - press to pause the game.";


    [Header("Pause and Quit Menu")]
    [SerializeField] string pauseMenuText = "Game Paused";
    [SerializeField] string resumeButton = "Resume";
    [SerializeField] string quitMenuText = "Congratuations!";
    [SerializeField] string quitButton = "Quit";



    public string GetLanguage()
    {
        return language;
    }

    public string GetHint()
    {
        return findButtonHint;
    }

    public string GetMovingExplanation()
    {
        return movingKeys + movingExplanationText;
    }

    public string GetSprintingExplanation()
    {
        return shiftKey + shiftExplanationText;
    }

    public string GetJumpingExplanation()
    {
        return spaceBar + spaceExplanationText;
    }

    public string GetPauseExplanation()
    {
        return escapeKey + escapeExplanationKey;
    }

    public string GetPauseMenuText()
    {
        return pauseMenuText;
    }

    public string GetResumeButtonText()
    {
        return resumeButton;
    }

    public string GetQuitMenuText()
    {
        return quitMenuText;
    }
    public string GetQuitButtonText()
    {
        return quitButton;
    }

}
