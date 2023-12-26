using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] List<Transform> playerTransform;
    [SerializeField] float playerMovingSpeed;
    [SerializeField] Transform gamePlatform;

    List<Player> players;
    PlatformHelper platformHelper;
    bool reached = false;

    // Start is called before the first frame update
    void Start()
    {
        players = GameStats.GetPlayerList();
        platformHelper = gamePlatform.GetComponent<PlatformHelper>();
    }

    // Update is called once per frame
    void Update()
    {

        if (GameStats.currentState == GameState.NEXT_PLAYER)
        {

            return;
        }

        if (GameStats.currentState == GameState.MOVE)
        {
            if (GameStats.UI.DiceResult == 0)
            {
                GameStats.currentState = GameState.ROLL_DICE; // for test, should be EXE FEATURE
                return;
            }

            int playerIndex = GameStats.CurrentPlayerIndex;
            Vector3 destPoint = platformHelper.GetWalkingPoint((players[playerIndex].StandingPos + 1) % 32).position;
            Vector3 playerPos = playerTransform[playerIndex].position;
            
            if (MyTools.Distance2D(playerPos, destPoint) > 0.1)
            {
                Vector3 temp = (destPoint - playerPos);
                Vector3 dirToDest = new Vector3(temp.x, 0, temp.z).normalized;
                playerTransform[playerIndex].localPosition += dirToDest * (playerMovingSpeed * Time.deltaTime);
            } else
            {
                GameStats.UI.DiceResult--;
                players[playerIndex].StandingPos = (players[playerIndex].StandingPos + 1) % 32;

            }
            return;
        }
    }
}
