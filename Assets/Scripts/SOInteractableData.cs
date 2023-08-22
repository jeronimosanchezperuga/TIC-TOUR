using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Interactable",menuName ="ScriptableObjects/Interactable")]
public class SOInteractableData : ScriptableObject
{
    public string instructions = "Accione el comando indicado para interactuar";
    public string failedMessage = "No se pudo realizar la acción";
    public string successMessage = "Acción exitosa";

    internal void ShowSuccessMessage()
    {
        UIManager.Instance.ShowInteractionResponse(successMessage);
    }

    public void ShowFailedMessage()
    {
        UIManager.Instance.ShowInteractionResponse(failedMessage);
    }
}
