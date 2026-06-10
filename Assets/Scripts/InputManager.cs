using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static float axis;

    public PlayerInput _playerInput;
    public InputAction _moveAction;
    

    void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        axis = new float();
        _moveAction = _playerInput.actions["Move"];
        
    }

    void Update()
    {
        axis = _moveAction.ReadValue<float>();
    }
}
