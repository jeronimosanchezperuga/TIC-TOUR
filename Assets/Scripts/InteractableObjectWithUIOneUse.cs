using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class InteractableObjectWithUIOneUse : MonoBehaviour
{
    public SOInteractableData data;
    [SerializeField] GameObject buttonGO;
    [SerializeField] GameObject infoGO;
    [SerializeField] TextMeshProUGUI buttonText;
    [SerializeField] TextMeshProUGUI infoText;
    [SerializeField] Canvas canvas;
    [SerializeField] bool used;

    private void Start()
    {
        canvas.worldCamera = Camera.main;
        HideInteraction();
        used = false;
    }
    public virtual void InteractionBehavior()
    {
        ShowInteractionInfo(data.successMessage);
        used = true;
        buttonGO.SetActive(false);
    }

    private void ShowInteractionInfo(string successMessage)
    {
        infoGO.SetActive(true);
        buttonGO.SetActive(false);
        infoText.text = successMessage;
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
        if (other.gameObject.CompareTag("Player") && !used)
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