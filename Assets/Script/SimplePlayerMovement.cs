using UnityEngine;

/// <summary>
/// 
/// </summary>
[RequireComponent(typeof(CharacterController))]
public class SimplePlayerMovement : MonoBehaviour
{
    [Header("Character")]
    // Reference to the character controller
    [SerializeField]
    private CharacterController character;

    // Character movement speed
    [SerializeField]
    private float moveSpeed = 4;

    [Header("Camera")]
    // Reference to the character camera
    [SerializeField]
    private Camera characterCamera;

    // Camera movement speed
    [SerializeField]
    private float camSpeed = 32;


    /// <summary>
    /// 
    /// </summary>
    private void Start()
    {
        // Lock and hide cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    /// <summary>
    /// 
    /// </summary>
    private void Update()
    {
        
        var v = Input.GetAxis("Vertical");
        var h = Input.GetAxis("Horizontal");

        
        var move = new Vector3(h, 0, v);
        move = character.transform.rotation * move;

        // If length of move vector is bigger than 6, normalized.
        if (move.magnitude > 1)
            move = move.normalized;

       
        character.SimpleMove(move * moveSpeed);

        // Get player mouse input for cameras
        var mx = Input.GetAxisRaw("Mouse X");
        var my = Input.GetAxisRaw("Mouse Y");

        // Rotate character with mouse X value
        character.transform.Rotate(Vector3.up, mx * camSpeed);

        // Get camera rotation on X axis
        var currentRotationX = characterCamera.transform.localEulerAngles.x;
        currentRotationX += my * camSpeed;

        // Limited camera movement to (-60) - (60) degrees on X axis
        if (currentRotationX < 180)
        {
            currentRotationX = Mathf.Min(currentRotationX, 60);
        }
        else if (currentRotationX > 180)
        {
            currentRotationX = Mathf.Max(currentRotationX, 300);
        }

        // Assigned new camera rotation
        characterCamera.transform.localEulerAngles = new Vector3(currentRotationX, 0, 0);

    }
}
