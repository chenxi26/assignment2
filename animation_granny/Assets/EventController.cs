using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour {

    public void onposterenter ()
    {
        this.GetComponent<Animator>().SetBool("Gaze", true);
    }
    public void onposterexit()
    {
        this.GetComponent<Animator>().SetBool("Gaze", false);
    }
}
