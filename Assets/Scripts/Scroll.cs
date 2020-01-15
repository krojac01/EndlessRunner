using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    void FixedUpdate()
    {
        if (PlayerController.isDead) return;

        this.transform.position += PlayerController.player.transform.forward * -0.1f;           // player run speed

        if (PlayerController.currentPlatform == null) return;
        if(PlayerController.currentPlatform.tag == "stairsUp")
            this.transform.Translate(0, -0.06f, 0);         //stairs are roughly 60 degree angle so the 0.06f 
        if (PlayerController.currentPlatform.tag == "stairsDown")
            this.transform.Translate(0, 0.06f, 0);         

    }
}
