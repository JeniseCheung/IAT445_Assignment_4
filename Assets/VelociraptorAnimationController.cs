using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaptorAnimationTest : MonoBehaviour
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
                animator.SetTrigger("IdleTrigger"); // Trigger animation
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
                animator.SetTrigger("RoarTrigger"); // Trigger animation
                Debug.Log("Roar animation triggered!");
            }
            else
            {
                Debug.LogError("Animator is missing!");
            }
        }
    }
}
