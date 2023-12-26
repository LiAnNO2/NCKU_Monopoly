using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformHelper : MonoBehaviour
{
    private List<Transform> blocks;

    // Start is called before the first frame update
    void Start()
    {
        blocks = new List<Transform>();
        for (int i = 0; i < 4; i++)
        {
            // add corner
            Transform corner = transform.GetChild(0).GetChild(i);
            blocks.Add(corner);
            // add side
            Transform side = transform.Find($"Side{i+1}");
            for (int j = 0; j < side.childCount; j++)
            {
                blocks.Add(side.GetChild(j));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Transform GetBlockTransform(int index)
    {
        return blocks[index];
    }

    public Transform GetWalkingPoint(int index)
    {
        return blocks[index].Find("WalkingPoint");
    }
}
