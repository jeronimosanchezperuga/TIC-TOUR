using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableDoor : InteractableObject
{
    [SerializeField] bool isLocked;

    public override void InteractionBehavior()
    {
        if (!GameManager.Instance.hasKey && isLocked)
        {
            data.ShowFailedMessage();
        }
        else
        {
            isLocked = false;
            GameManager.Instance.hasKey = false;
            DoorOpen();
        }

    }

    private void DoorOpen()
    {
        data.ShowSuccessMessage();
    }
}
