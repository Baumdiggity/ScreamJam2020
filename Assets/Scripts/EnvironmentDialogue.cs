using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class EnvironmentDialogue : MonoBehaviour
{
    [SerializeField]
    string nodeName;

    [SerializeField]
    string prompt;

    
    DialogueRunner runner;
    Indicator indicator;

    private void Start()
    {
        runner = FindObjectOfType<DialogueRunner>();
        indicator = FindObjectOfType<Indicator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            indicator.SetText(prompt);
            indicator.SetFlag(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                runner.StartDialogue(nodeName);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            indicator.SetFlag(false);
        }
    }
}
