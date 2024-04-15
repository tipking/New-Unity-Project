using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class NewBehaviourScript2 : MonoBehaviour
{
    
    /// Door Access.
    /// Method called very frame...
    /// <summary>
    /// Saint Globin Clear View !!!
    /// </summary>

    private Rigidbody rb;
    public Rigidbody Rb => rb;

    private void Awake()
    {
        // Reference to the rigidbody.
        Debug.Log("Get Comp");
        rb = GetComponent<Rigidbody>();
    }
}
