using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Created with the help of ChatGPT
public class VelociraptorVRController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Try to find the Animator on the object or its children
        animator = GetComponentInChildren<Animator>();

        if (animator == null)
        {
            Debug.LogError("Animator NOT found! Make sure the Velociraptor has one.");
        }
        else
        {
            Debug.Log("Animator found: " + animator.gameObject.name);
        }
    }

    void Update()
    {
        // Check for VR controller inputs using OVRInput

        // A Button - Idle animation
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            if (animator != null)
            {
                animator.SetTrigger("IdleTrigger");
                Debug.Log("Idle animation triggered!");
            }
            else
            {
                Debug.LogError("Animator is missing!");
            }
        }

        // B Button - Roar animation
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            if (animator != null)
            {
                animator.SetTrigger("RoarTrigger");
                Debug.Log("Roar animation triggered!");
            }
            else
            {
                Debug.LogError("Animator is missing!");
            }
        }

        // Thumbstick Press - Run animation
        if (OVRInput.GetDown(OVRInput.Button.PrimaryThumbstick))
        {
            if (animator != null)
            {
                animator.SetTrigger("RunTrigger");
                Debug.Log("Run animation triggered!");
            }
            else
            {
                Debug.LogError("Animator is missing!");
            }
        }

        // Hand Trigger (Grip) - Attack animation
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
        {
            if (animator != null)
            {
                animator.SetTrigger("AttackTrigger");
                Debug.Log("Attack animation triggered!");
            }
            else
            {
                Debug.LogError("Animator is missing!");
            }
        }

        // Index Trigger - Death animation
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            if (animator != null)
            {
                animator.SetTrigger("DeathTrigger");
                Debug.Log("Death animation triggered!");
            }
            else
            {
                Debug.LogError("Animator is missing!");
            }
        }
    }
}
