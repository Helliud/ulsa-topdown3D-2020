using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    [SerializeField]
    Potion potion;

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    private void OnTriggerEnter(Collider other)
    {
        potion.Drink();
        Debug.Log("Healt restored");
    }
}
