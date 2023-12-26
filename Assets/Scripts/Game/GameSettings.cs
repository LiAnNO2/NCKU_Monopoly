using System.Collections;
using System.Collections.Generic;


public enum CameraDirection
{
    PLAYER,
    DORM,
    HOSTPITAL,
    LIBRARY,
    PARK,
}

public static class GameSettings
{
    public static readonly int MAX_PLAYER = 4;
    public static int TargetCredit = 130;
    public static int MaxEmotion = 10;
    public static CameraDirection cameraDirection = CameraDirection.PLAYER;
}
