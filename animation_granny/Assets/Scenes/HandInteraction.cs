using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandInteraction : MonoBehaviour {


    public Transform Granny;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = this.GetComponent<Transform>().position;
        Vector3 Grannyposition = Granny.position;
        if (Vector3.Distance(position,Grannyposition)<0.1)
        
{
            Granny.GetComponent<Animator>().SetBool("Swim", true);
        } else
        {
            Granny.GetComponent<Animator>().SetBool("Swim", false);
        }

            }


}
