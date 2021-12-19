//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Scripts/Player/PlayerInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerActionControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActionControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""637ee009-1d12-48ea-abac-b514cb66a685"",
            ""actions"": [
                {
                    ""name"": ""MoveLeftRight"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c08f6c87-c071-4130-a672-552303d44ba8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveUpDown"",
                    ""type"": ""Button"",
                    ""id"": ""387c357d-66c7-4942-b98f-a9ccbe4e8d8b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Left/Right WASD"",
                    ""id"": ""ec6c13d5-53b8-49ac-9ce0-a1cadc1842db"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeftRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""831ed22f-d327-4301-bfee-6c0c3c0dd8a2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""04de846e-ba3e-45fe-9a5c-87d824aaf37c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Up/Down WASD"",
                    ""id"": ""07e861e2-27ad-4170-a0c8-de411c9427b2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUpDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5c752fe2-51a8-4ce1-8b61-091062113a96"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0b6bf632-9942-4646-a3b3-04000a63fdfc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_MoveLeftRight = m_Movement.FindAction("MoveLeftRight", throwIfNotFound: true);
        m_Movement_MoveUpDown = m_Movement.FindAction("MoveUpDown", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_MoveLeftRight;
    private readonly InputAction m_Movement_MoveUpDown;
    public struct MovementActions
    {
        private @PlayerActionControls m_Wrapper;
        public MovementActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveLeftRight => m_Wrapper.m_Movement_MoveLeftRight;
        public InputAction @MoveUpDown => m_Wrapper.m_Movement_MoveUpDown;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @MoveLeftRight.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMoveLeftRight;
                @MoveLeftRight.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMoveLeftRight;
                @MoveLeftRight.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMoveLeftRight;
                @MoveUpDown.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMoveUpDown;
                @MoveUpDown.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMoveUpDown;
                @MoveUpDown.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMoveUpDown;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveLeftRight.started += instance.OnMoveLeftRight;
                @MoveLeftRight.performed += instance.OnMoveLeftRight;
                @MoveLeftRight.canceled += instance.OnMoveLeftRight;
                @MoveUpDown.started += instance.OnMoveUpDown;
                @MoveUpDown.performed += instance.OnMoveUpDown;
                @MoveUpDown.canceled += instance.OnMoveUpDown;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    public interface IMovementActions
    {
        void OnMoveLeftRight(InputAction.CallbackContext context);
        void OnMoveUpDown(InputAction.CallbackContext context);
    }
}
