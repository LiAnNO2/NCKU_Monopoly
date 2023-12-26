using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] List<Transform> playerTransform;
    [SerializeField] float playerMovingSpeed;
    [SerializeField] Transform gamePlatform;

    PlatformHelper platformHelper;
    bool reached = false;

    // Start is called before the first frame update
    void Start()
    {
        platformHelper = gamePlatform.GetComponent<PlatformHelper>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameStats.currentState == GameState.MOVE)
        {
            int playerIndex = GameStats.CurrentPlayerIndex;
            
        }
    }
}
