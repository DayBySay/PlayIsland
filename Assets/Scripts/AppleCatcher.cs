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
        apple.Catch();
    }
}
