using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree_incongruent : MonoBehaviour
{
    // moves tree if plane was crossed 17f up
    public void Move()
    {
        transform.Translate(0f, 18f, 0f);
    }
}
