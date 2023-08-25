using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class InteractableObjectWithUI : MonoBehaviour
{
    public SOInteractableData data;
    [SerializeField] GameObject buttonGO;
    [SerializeField] GameObject infoGO;
    [SerializeField] TextMeshProUGUI buttonText;
    [SerializeField] TextMeshProUGUI infoText;
    [SerializeField] Canvas canvas;

    private void Start()
    {
        canvas.worldCamera = Camera.main;
        HideInteraction();
    }
    public virtual void InteractionBehavior()
    {
        ShowInteractionInfo(data.failedMessage);
        buttonGO.SetActive(false);
    }

    private void ShowInteractionInfo(string failedMessage)
    {
        infoGO.SetActive(true);
        infoText.text = failedMessage;
    }

    private void ShowInteractionButton(string instructions)
    {
        buttonGO.SetActive(true);
        buttonText.text = instructions;
    }

    private void HideInteraction()
    {
        buttonGO.SetActive(false);
        infoGO.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ShowInteractionButton(data.instructions);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            HideInteraction();
        }
    }

}