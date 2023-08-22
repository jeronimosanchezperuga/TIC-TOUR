using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    [SerializeField] KeyCode interactionKey;
    public InteractableObject currentInteractable;
    public static InteractionManager Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Instance);
        }
        else
        {
            Instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(interactionKey))
        {
            if (currentInteractable) { 
            
                currentInteractable.InteractionBehavior();
                UIManager.Instance.HideInteraction();
            }
        }
    }

    public void ActivateCurrentInteractable()
    {
        if (currentInteractable)
        {

            currentInteractable.InteractionBehavior();
            UIManager.Instance.HideInteraction();
        }
    }
}
