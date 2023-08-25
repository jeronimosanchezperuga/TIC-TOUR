﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class InteractableWithUIPickable : MonoBehaviour
{
    public SOInteractableData data;
    [SerializeField] GameObject buttonGO;
    [SerializeField] GameObject infoGO;
    [SerializeField] TextMeshProUGUI buttonText;
    [SerializeField] TextMeshProUGUI infoText;
    [SerializeField] GameObject modelo;
    [SerializeField] Canvas canvas;
    GameObject go;

    private void Start()
    {
        canvas.worldCamera = Camera.main;
        HideInteraction();
    }
    public void InteractionBehavior()
    {
        if (CheckForConditions())
        {
            ShowInteractionInfo(data.successMessage);
            GameManager.Instance.hasKey = true;
            SuccessBehavior();
        }
        else
        {
            ShowInteractionInfo(data.failedMessage);
        }
        buttonGO.SetActive(false);
        go = infoGO;
        Invoke(nameof(DeactivateGO), 3);
    }

    private void SuccessBehavior()
    {
        Destroy(modelo);
        go = gameObject;
        Invoke(nameof(DeactivateGO),3);
    }

    private bool CheckForConditions()
    {
        return !GameManager.Instance.hasKey;
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

    void DeactivateGO()
    {
        go.SetActive(false);
    }
}