//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Script/InputSystem/MobileInputActions.inputactions
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

public partial class @MobileInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MobileInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MobileInputActions"",
    ""maps"": [
        {
            ""name"": ""Action"",
            ""id"": ""c86bf9c3-1112-4c2d-8b1b-6b9df505bb98"",
            ""actions"": [
                {
                    ""name"": ""TurnLeftorRight"",
                    ""type"": ""Button"",
                    ""id"": ""dafaa843-cba4-483f-8dfa-3de76ea5e443"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TurnRight"",
                    ""type"": ""Button"",
                    ""id"": ""c5ea7c3c-d323-4f2d-b37b-034a865db2ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""66a0a7be-bc7b-41b0-932c-4fa6ad728488"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PhoneRotate"",
                    ""type"": ""Button"",
                    ""id"": ""8f17f994-ec1e-4d23-bfa6-74abf96dcfec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d04c26d9-a0bd-469b-b729-48269fa4270b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnLeftorRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64eafaa3-2479-4604-a3b9-80cc7ff9a2d7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f46dcaab-145f-4315-8e9f-eb112a04901f"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12233951-f0ca-4722-8ca1-17df3a0ccda8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ec8a1bf-c4dd-4af6-8d8f-8dc7f3284689"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e14213bd-7700-4f11-8f99-86056a0cc063"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PhoneRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Action
        m_Action = asset.FindActionMap("Action", throwIfNotFound: true);
        m_Action_TurnLeftorRight = m_Action.FindAction("TurnLeftorRight", throwIfNotFound: true);
        m_Action_TurnRight = m_Action.FindAction("TurnRight", throwIfNotFound: true);
        m_Action_Jump = m_Action.FindAction("Jump", throwIfNotFound: true);
        m_Action_PhoneRotate = m_Action.FindAction("PhoneRotate", throwIfNotFound: true);
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

    // Action
    private readonly InputActionMap m_Action;
    private List<IActionActions> m_ActionActionsCallbackInterfaces = new List<IActionActions>();
    private readonly InputAction m_Action_TurnLeftorRight;
    private readonly InputAction m_Action_TurnRight;
    private readonly InputAction m_Action_Jump;
    private readonly InputAction m_Action_PhoneRotate;
    public struct ActionActions
    {
        private @MobileInputActions m_Wrapper;
        public ActionActions(@MobileInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @TurnLeftorRight => m_Wrapper.m_Action_TurnLeftorRight;
        public InputAction @TurnRight => m_Wrapper.m_Action_TurnRight;
        public InputAction @Jump => m_Wrapper.m_Action_Jump;
        public InputAction @PhoneRotate => m_Wrapper.m_Action_PhoneRotate;
        public InputActionMap Get() { return m_Wrapper.m_Action; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionActions set) { return set.Get(); }
        public void AddCallbacks(IActionActions instance)
        {
            if (instance == null || m_Wrapper.m_ActionActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ActionActionsCallbackInterfaces.Add(instance);
            @TurnLeftorRight.started += instance.OnTurnLeftorRight;
            @TurnLeftorRight.performed += instance.OnTurnLeftorRight;
            @TurnLeftorRight.canceled += instance.OnTurnLeftorRight;
            @TurnRight.started += instance.OnTurnRight;
            @TurnRight.performed += instance.OnTurnRight;
            @TurnRight.canceled += instance.OnTurnRight;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @PhoneRotate.started += instance.OnPhoneRotate;
            @PhoneRotate.performed += instance.OnPhoneRotate;
            @PhoneRotate.canceled += instance.OnPhoneRotate;
        }

        private void UnregisterCallbacks(IActionActions instance)
        {
            @TurnLeftorRight.started -= instance.OnTurnLeftorRight;
            @TurnLeftorRight.performed -= instance.OnTurnLeftorRight;
            @TurnLeftorRight.canceled -= instance.OnTurnLeftorRight;
            @TurnRight.started -= instance.OnTurnRight;
            @TurnRight.performed -= instance.OnTurnRight;
            @TurnRight.canceled -= instance.OnTurnRight;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @PhoneRotate.started -= instance.OnPhoneRotate;
            @PhoneRotate.performed -= instance.OnPhoneRotate;
            @PhoneRotate.canceled -= instance.OnPhoneRotate;
        }

        public void RemoveCallbacks(IActionActions instance)
        {
            if (m_Wrapper.m_ActionActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IActionActions instance)
        {
            foreach (var item in m_Wrapper.m_ActionActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ActionActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ActionActions @Action => new ActionActions(this);
    public interface IActionActions
    {
        void OnTurnLeftorRight(InputAction.CallbackContext context);
        void OnTurnRight(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPhoneRotate(InputAction.CallbackContext context);
    }
}
