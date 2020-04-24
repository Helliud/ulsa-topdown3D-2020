﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField]
    DialogTextBox npcTextBox;
    [SerializeField, TextArea(3, 5)]
    string npcDialog;

    public void StarTalking()
    {
        npcTextBox.gameObject.SetActive(true);
        npcTextBox.Message = npcDialog;
        npcTextBox.ShowDialog();
    }

    public void StopTalking()
    {
        npcTextBox.gameObject.SetActive(false);
        npcTextBox.ClearText();
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StarTalking();
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            StopTalking();
        }
    }
}
