
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Reference to the character camera.
    [SerializeField]
    private Camera characterCamera;

    // Reference to the slot for holding picked item.
    [SerializeField]
    private Transform slot;

    // Reference to the currently held item.
    private NewBehaviourScript2 pickedItem;

    // Update is called once per frame.
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Check Fired");
            if (pickedItem)
            {
                Debug.Log("Droped");
                DropItem(pickedItem);
            }
            else
            {
                // If no try pick item in front to the player...
                Debug.Log("Checking Objects");
                var ray = characterCamera.ViewportPointToRay(Vector3.one * 0.5f);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 7.5f))
                {
                    Debug.Log("Checking out component on scene2");
                    var pickable = hit.transform.GetComponent<NewBehaviourScript2>();
                    
                    if (pickable)
                    {
                        Debug.Log("Picked cubes from planes");
                        PickItem(pickable);
                    }
                }
            }
        }
    }
    /// <summary>
    /// Method for picking up item...
    /// </summary>
    ///
    ///
    private void PickItem(NewBehaviourScript2 item)
    {
        pickedItem = item;
        item.Rb.isKinematic = true;
        item.Rb.velocity = Vector3.zero;
        item.transform.SetParent(slot);
        item.Rb.angularVelocity = Vector3.zero;
        item.transform.localPosition = Vector3.zero;
        item.transform.localEulerAngles = Vector3.zero;
    }
    /// <summary>
    /// Method for dropping item...
    /// </summary>
	///
    ///
    private void DropItem(NewBehaviourScript2 item)
    {
        
        pickedItem = null;
        item.Rb.isKinematic = false;
        item.transform.SetParent(null);
        item.Rb.AddForce(item.transform.forward * 2, ForceMode.VelocityChange);
    }
}
