﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoldButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public PlayerController player;
    public int identity;
    public bool pencet;
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        //Output the name of the GameObject that is being clicked
        if (player.Move ) {
            //player.kenaTembok = false;
        }
        player.speed = 5;
        player.dir = identity;
        player.Move = true;
        pencet = true;
    }

    public int iden() {
        return identity;
    }

    //Detect if clicks are no longer registering
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        player.speed = 0;
        player.Move = false;

        pencet = false;
    }
}
