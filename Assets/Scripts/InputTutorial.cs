using UnityEngine;
using UnityEngine.InputSystem;

public class InputTutorial : MonoBehaviour, InputSystemTutorial.IPlayerActions {

    #region MONO

    void Update() {

        // Call both methods in Update
        HandleKeyboard();
        HandleMouse();

    }

    #endregion

    #region SPECIFIC

    // Wrapped in methods to handle each device so that you can return from function instead of Update
    private void HandleKeyboard() {
        var keyboard = Keyboard.current; // Get keyboard device last used
        if (keyboard == null) return;

        if (keyboard.aKey.wasPressedThisFrame) {
            Debug.Log("A key was pressed!");
        }

    }

    private void HandleMouse() {
        var mouse = Mouse.current; // Get last mouse device used
        if (mouse == null) return;

        var delta = mouse.delta.ReadValue();
        // Todo: Do something with mouse delta
    }
    
    public void Fire() {
        Debug.Log("Fire!");
    }

    #endregion

    #region INPUT

    public void OnMove(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnLook(InputAction.CallbackContext context) {
        throw new System.NotImplementedException();
    }

    public void OnFire(InputAction.CallbackContext context) {
        if (!context.performed) return;
        
        Debug.Log("Fire! (Interface)");
    }

    #endregion
}

