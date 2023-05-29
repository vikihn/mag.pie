using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToShowItem : MonoBehaviour
{
    public GameObject targetItem; // Reference to the item that will appear

    private void OnMouseDown()
    {
        // Check if the target item is not null
        if (targetItem != null)
        {
            // Enable or instantiate the target item
            targetItem.SetActive(true); // Uncomment this line if the target item is already in the scene
            // Instantiate(targetItem, transform.position, Quaternion.identity); // Uncomment this line if the target item needs to be instantiated
        }
    }
}