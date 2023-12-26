using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExecutor : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameStats.currentState == GameState.MOVE)
        {
            
        }
    }

    public void RollTheDice()
    {
        if (GameStats.currentState != GameState.ROLL_DICE) return;
        GameStats.UI.DiceResult = new System.Random().Next(1, 6+1);
        GameStats.currentState = GameState.MOVE;
        GameSettings.cameraDirection = CameraDirection.PLAYER;
    }

    public void ChangeToNextPlayer()
    {
        GameStats.CurrentPlayerIndex = (GameStats.CurrentPlayerIndex + 1) % GameSettings.MAX_PLAYER;
    }
}
