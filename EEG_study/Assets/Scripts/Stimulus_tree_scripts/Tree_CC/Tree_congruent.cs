using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree_congruent : MonoBehaviour
{
    // moves tree if plane was crossed 17f up
    public void Move()
    {
        transform.Translate(0f, 19f, 0f);
    }
}
