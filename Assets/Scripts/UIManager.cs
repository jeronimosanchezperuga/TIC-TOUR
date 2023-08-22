using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMissionDescript; 
    public TextMeshProUGUI txtInteractionResponse;
    public TextMeshProUGUI txtInstructions;
    public GameObject panelText;
    public GameObject panelInteraction;
    public GameObject panelInstructions;

    public static UIManager Instance { get; private set; }


    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null  && Instance != this)
        {
            Destroy(Instance);
        }
        else
        {
            Instance = this;
        }
    }

    public void ShowInteractionResponse(string v)
    {
        StartCoroutine(ShowMessageAndHideAfterSeconds(2, panelInteraction));
        txtInteractionResponse.text = v;
    }

    public void ShowInteraction(string text)
    {
        panelInstructions.SetActive(true);
        txtInstructions.text = text;
    }

    public void HideInteraction()
    {
        panelInstructions.SetActive(false);
    }
    
    public void ShowMissionDescription(string description)
    {
        txtMissionDescript.text = description;
    }

    IEnumerator ShowMessageAndHideAfterSeconds(float seconds, GameObject panel)
    {
        panel.SetActive(true);
        yield return new WaitForSeconds(seconds);
        panel.SetActive(false);
    }
}
