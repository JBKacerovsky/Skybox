// GENERATED AUTOMATICALLY FROM 'Assets/Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Input : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""Look"",
            ""id"": ""5e294651-ed9c-4b56-994a-16525df4472f"",
            ""actions"": [
                {
                    ""name"": ""mousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""e03f937a-474f-437b-aca7-346fc482b107"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""leftClick"",
                    ""type"": ""Button"",
                    ""id"": ""1aa65f17-aaa6-44b9-bdcc-192d0365804e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""35324417-2794-480d-9b92-33116f8a73b2"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd38488c-63e8-43d6-9847-3126b0d28d2c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""leftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Look
        m_Look = asset.FindActionMap("Look", throwIfNotFound: true);
        m_Look_mousePosition = m_Look.FindAction("mousePosition", throwIfNotFound: true);
        m_Look_leftClick = m_Look.FindAction("leftClick", throwIfNotFound: true);
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

    // Look
    private readonly InputActionMap m_Look;
    private ILookActions m_LookActionsCallbackInterface;
    private readonly InputAction m_Look_mousePosition;
    private readonly InputAction m_Look_leftClick;
    public struct LookActions
    {
        private @Input m_Wrapper;
        public LookActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @mousePosition => m_Wrapper.m_Look_mousePosition;
        public InputAction @leftClick => m_Wrapper.m_Look_leftClick;
        public InputActionMap Get() { return m_Wrapper.m_Look; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LookActions set) { return set.Get(); }
        public void SetCallbacks(ILookActions instance)
        {
            if (m_Wrapper.m_LookActionsCallbackInterface != null)
            {
                @mousePosition.started -= m_Wrapper.m_LookActionsCallbackInterface.OnMousePosition;
                @mousePosition.performed -= m_Wrapper.m_LookActionsCallbackInterface.OnMousePosition;
                @mousePosition.canceled -= m_Wrapper.m_LookActionsCallbackInterface.OnMousePosition;
                @leftClick.started -= m_Wrapper.m_LookActionsCallbackInterface.OnLeftClick;
                @leftClick.performed -= m_Wrapper.m_LookActionsCallbackInterface.OnLeftClick;
                @leftClick.canceled -= m_Wrapper.m_LookActionsCallbackInterface.OnLeftClick;
            }
            m_Wrapper.m_LookActionsCallbackInterface = instance;
            if (instance != null)
            {
                @mousePosition.started += instance.OnMousePosition;
                @mousePosition.performed += instance.OnMousePosition;
                @mousePosition.canceled += instance.OnMousePosition;
                @leftClick.started += instance.OnLeftClick;
                @leftClick.performed += instance.OnLeftClick;
                @leftClick.canceled += instance.OnLeftClick;
            }
        }
    }
    public LookActions @Look => new LookActions(this);
    public interface ILookActions
    {
        void OnMousePosition(InputAction.CallbackContext context);
        void OnLeftClick(InputAction.CallbackContext context);
    }
}
