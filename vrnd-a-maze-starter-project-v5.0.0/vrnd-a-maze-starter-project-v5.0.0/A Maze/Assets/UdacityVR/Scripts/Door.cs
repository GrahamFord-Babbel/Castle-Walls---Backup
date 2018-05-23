using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    [Tooltip("The name of the Animator trigger parameter")]
    public string animationName1;
    [Tooltip("The name of the Animator trigger parameter")]
    public string animationName2;
    [Tooltip("The Animator component on this gameobject")]
    public Animator stateMachine1;
    public Animator stateMachine2;
    public GameObject door;
    public GameObject chest;
    public GameObject lockedText;
    public GameObject key;

    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    bool locked;
    // Create a boolean value called "opening" that can be checked in Update() 
    bool opening;
    public bool hasKey;
    float doorOrigin;

    public void Start()
    {
        locked = true;
        opening = false;
        lockedText.SetActive(false);
    }

    void Update() {
        // If the door is opening and it is not fully opened
        doorOrigin = transform.position.x;
            // Animate the door to stay fully opened
            if (opening == true && doorOrigin < 6)
        {
            //start animation - door opening
            stateMachine1.SetTrigger(animationName1);
            //start animation - chest opening
            stateMachine2.SetTrigger(animationName2);
        }
    }

    public void OnDoorClicked() {
        //test clicked
        print("door clicked");
        // If the door is clicked and unlocked
        if (locked == false)
        {
            // Set the "opening" boolean to true
            opening = true;
            //play opening audio
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            lockedText.SetActive(false);
        }
        // (optionally) Else
        // Play a sound to indicate the door is locked
        else
        {
            lockedText.SetActive(true);
        }
}

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        if (hasKey == true)
        {
            locked = false;
        }
    }
}
