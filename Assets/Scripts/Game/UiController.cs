using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [SerializeField] List<Image> statsPanels;
    [SerializeField] Text diceResult;

    List<Player> playerList;

    // Start is called before the first frame update
    void Start()
    {
        playerList = GameStats.GetPlayerList();
        playerList.Add(new Player("Anya", "Image/anya"));
        playerList.Add(new Player("Saugy1", "Image/saugy"));
        playerList.Add(new Player("Saugy2", "Image/saugy"));
        playerList.Add(new Player("Saugy3", "Image/saugy"));

        for (int i = 0; i < playerList.Count; i++)
        {
            InitializePlayerCard(playerList[i], statsPanels[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        diceResult.text = GameStats.UI.DiceResult.ToString();
    }

    public void GoToNextCamera()
    {
        CameraDirection curr = GameSettings.cameraDirection;
        switch (curr)
        {
            case CameraDirection.PLAYER: 
                GameSettings.cameraDirection = CameraDirection.DORM;
                break;
            case CameraDirection.DORM:
                GameSettings.cameraDirection = CameraDirection.HOSTPITAL;
                break;
            case CameraDirection.HOSTPITAL:
                GameSettings.cameraDirection = CameraDirection.LIBRARY;
                break;
            case CameraDirection.LIBRARY:
                GameSettings.cameraDirection = CameraDirection.PARK;
                break;
            case CameraDirection.PARK:
                GameSettings.cameraDirection = CameraDirection.PLAYER;
                break;
            default:
                GameSettings.cameraDirection = CameraDirection.PLAYER;
                break;
        }
    }

    private void InitializePlayerCard(Player player, Image panel)
    {
        Text textName = panel.transform.Find("Name").GetComponent<Text>();
        Image iconImage = panel.transform.Find("Image").GetComponent<Image>();

        textName.text = player.Name;
        iconImage.sprite = Resources.Load<Sprite>(player.ImagePath);

        UpdatePlayerCardValue(player, panel);
    }

    private void UpdatePlayerCardValue(Player player, Image panel)
    {
        Text valueCredit = panel.transform.Find("ValueCredit").GetComponent<Text>();
        Text valueEmotion = panel.transform.Find("ValueEmotion").GetComponent<Text>();
        valueCredit.text = $"{player.Credit}/{GameSettings.TargetCredit}";
        valueEmotion.text = $"{player.Emotion}/{GameSettings.MaxEmotion}";
    }

}
