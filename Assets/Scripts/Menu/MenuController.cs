using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] Button startButton;
    [SerializeField] Button ruleButton;
    [SerializeField] Button exitButton;

    private static readonly int gameSceneIndex = 1;

    private void Start()
    {
        startButton.onClick.AddListener(onStartButtonClick);
        ruleButton.onClick.AddListener(onRuleButtonClick);
        exitButton.onClick.AddListener(onExitButtonClick);
    }

    private void onStartButtonClick()
    {
        SceneManager.LoadScene(gameSceneIndex);
    }

    private void onRuleButtonClick()
    {

    }

    private void onExitButtonClick()
    {
        Application.Quit();
    }
}
