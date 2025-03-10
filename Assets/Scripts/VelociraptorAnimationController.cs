using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Created with the help of ChatGPT
public class VelociraptorAnimationController : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.I))
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

        if (Input.GetKeyDown(KeyCode.R))
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

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (animator != null)
            {
                animator.SetTrigger("RunTrigger"); // Trigger Run animation
                Debug.Log("Run animation triggered!");
            }
            else
            {
                Debug.LogError("Animator is missing!");
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
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

        if (Input.GetKeyDown(KeyCode.D))
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
