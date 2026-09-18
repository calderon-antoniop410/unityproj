// PlayerMovement.cs
// Used in: Slide 5 (concept), Slide 8 (add PlayerInput + script), Slide 9 (press play and move)
//
// Attach this to the player GameObject alongside a PlayerInput component.
// PlayerInput must have its Actions asset assigned, Default Map set to "Player",
// and Behavior set to "Send Messages" so Unity calls OnMove() automatically
// whenever the "Move" action fires.

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 moveInput;

    // Called automatically by PlayerInput (Send Messages) whenever
    // the "Move" action's value changes. The method name must be
    // "On" + the action name, exactly, including capitalization.
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    private void Update()
    {
        transform.Translate(moveInput * Time.deltaTime * 5f);
    }
}
