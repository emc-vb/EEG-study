using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Tree_CI : MonoBehaviour
{

    public AudioSource source;
    public AudioClip clip;

    [SerializeField]
    public Tree_incongruent _tree;


    // play audio and show stimulus
    private void OnTriggerEnter(Collider other)
    {
        // delay
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        // tree will appear
        _tree.Move();
        // delay
        yield return new WaitForSeconds(2);
        // when player passes the plane infront of the tree audio will be played
        source.PlayOneShot(clip);

    }
}
