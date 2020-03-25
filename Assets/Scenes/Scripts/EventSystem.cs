﻿using System;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    public static EventSystem current;

    private void Awake() {
        current = this;
    }

    public event Action<int> onDoorwayTriggerEnter;
    public void DoorwayTriggerEnter(int id){

        if(onDoorwayTriggerEnter != null){
            onDoorwayTriggerEnter(id);
        }
    }

    public event Action<int> onDoorwayTriggerExit;
    public void DoorwayTriggerExit(int id){

        if(onDoorwayTriggerExit != null){
            onDoorwayTriggerExit(id);
        }
    }
}
