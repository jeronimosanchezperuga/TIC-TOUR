using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableKey : InteractableObject
{
    public override void InteractionBehavior()
    {
        data.ShowSuccessMessage();
        KeyPicked();
    }

    void KeyPicked()
    {
        GameManager.Instance.hasKey = true;
        gameObject.SetActive(false);
    }
}
