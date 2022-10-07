using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChosedGUILanguage : MonoBehaviour
{
    [Header("Game Language")]
    [SerializeField] Languages language;

    [Header("Hint Labels")]
    [SerializeField] TextMeshProUGUI hintLabel;
    [SerializeField] TextMeshProUGUI movingLabel;
    [SerializeField] TextMeshProUGUI sprintingLabel;
    [SerializeField] TextMeshProUGUI jumpingLabel;
    [SerializeField] TextMeshProUGUI pauseLabel;

    [Header("Pause Menu Labels")]
    [SerializeField] TextMeshProUGUI pauseMenuLabel;
    [SerializeField] TextMeshProUGUI resumeButtonText;
    [SerializeField] TextMeshProUGUI quitButtonText;

    [Header("Quit Menu Labels")]
    [SerializeField] TextMeshProUGUI WonLabel;
    [SerializeField] TextMeshProUGUI quitBtnText;


    void Start()
    {
        GUIFillingUsingChosedLanguage();
    }

    private void GUIFillingUsingChosedLanguage()
    {
        //Hint text filling
        hintLabel.text = language.GetHint();
        movingLabel.text = language.GetMovingExplanation();
        sprintingLabel.text = language.GetSprintingExplanation();
        jumpingLabel.text = language.GetJumpingExplanation();
        pauseLabel.text = language.GetPauseExplanation();

        //Pause & Quit Menu text filling
        pauseMenuLabel.text = language.GetPauseMenuText();
        resumeButtonText.text = language.GetResumeButtonText();
        quitButtonText.text = language.GetQuitButtonText();
        WonLabel.text = language.GetQuitMenuText();
        quitBtnText.text = language.GetQuitButtonText();
    }

    void Update()
    {
        
    }
}
