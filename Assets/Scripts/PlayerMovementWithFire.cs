// PlayerMovementWithFire.cs
// Used in: Slide 11, Extra Challenge (Input System)
//
// This is PlayerMovement.cs extended with a second action, "Fire" (type Button,
// bound to Space), to show two independent actions working side by side.
// Add a second action called "Fire" to the same "Player" Action Map in your
// Input Actions asset before this will fire.

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementWithFire : MonoBehaviour
{
    private Vector2 moveInput;

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    // Button actions don't carry a value the same way Vector2 actions do,
    // so we just react to the method being called at all.
    public void OnFire(InputValue value)
    {
        if (value.isPressed)
        {
            Debug.Log("Fire!");
        }
    }

    private void Update()
    {
        transform.Translate(moveInput * Time.deltaTime * 5f);
    }
}
