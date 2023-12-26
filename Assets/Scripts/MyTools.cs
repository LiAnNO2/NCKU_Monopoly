using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MyTools
{
    public static float Distance2D(Vector3 a, Vector3 b)
    {
        return (float) Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.z - b.z, 2));
    }
}
