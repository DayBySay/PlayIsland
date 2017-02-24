using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleCatcher : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "apple")
        {
            return;
        }

        Apple apple = other.GetComponent<Apple>();
        AudioSource source = apple.GetComponent<AudioSource> ();
        source.PlayOneShot (source.clip);
        apple.Catch();
    }
}
