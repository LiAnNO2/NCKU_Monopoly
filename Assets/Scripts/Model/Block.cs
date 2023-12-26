using System.Collections;
using System.Collections.Generic;

public enum BlockType {
    DEPARTMENT,
    OPPORTUNITY,
    DESTINY,
    DORM,
    HOSPITAL,
    LIBRARY,
    PARK,
}

public class Block
{
    public BlockType Type { get; private set; }
}
