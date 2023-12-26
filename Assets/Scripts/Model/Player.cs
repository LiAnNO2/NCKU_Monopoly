using System.Collections;
using System.Collections.Generic;

public class Player
{
    public string Name { get; set; }
    public int Credit { get; set; }
    public int Emotion { get; set; }
    public string ImagePath { get; set; }
    public int StandingPos { get; set; }

    public Player(string name, string imagePath)
    {
        Name = name;
        Credit = 0;
        Emotion = 0;
        ImagePath = imagePath;
        StandingPos = 0;
    }
}
