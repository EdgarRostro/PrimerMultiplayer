// GENERATED AUTOMATICALLY FROM 'Assets/Midnight Sky by Ivana Carrizalez/Animation/PlayerActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""TheaMain"",
            ""id"": ""32632bbd-6bf3-4fc5-b40c-cdcd2cd45be0"",
            ""actions"": [
                {
                    ""name"": ""Run"",
                    ""type"": ""PassThrough"",
                    ""id"": ""74c55c99-f362-4374-9aa9-7c5c59e14e98"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""cd707127-60ac-44e8-b3df-f9dfae904f23"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""da393ed8-97e2-492e-acb2-c4202eaad119"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shot"",
                    ""type"": ""Button"",
                    ""id"": ""8708e084-94db-45da-b47a-c64406db8e18"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""594a7f13-85cf-480c-bc88-83403e758d23"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""5c64acc7-ab9a-415e-bab9-0f8f87ecb22a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""dd0205a0-e7f2-4d74-ac58-464c3df9ab6b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5882e4e5-7871-4783-8d72-064ca4e29378"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6b11bda4-f08c-41ac-9127-4a7e01dda1d0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""89e716a2-973d-4394-98a8-6ab584ba6c33"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6a6afd91-505f-42ca-9084-497d19839e91"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1edee304-8f57-4bde-9265-a6d826513ceb"",
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
                    ""id"": ""66fadb6f-8220-4a7d-9ca4-b041cc6d19ec"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f74c778-f4a1-430c-ac66-e520a0ef658f"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // TheaMain
        m_TheaMain = asset.FindActionMap("TheaMain", throwIfNotFound: true);
        m_TheaMain_Run = m_TheaMain.FindAction("Run", throwIfNotFound: true);
        m_TheaMain_Jump = m_TheaMain.FindAction("Jump", throwIfNotFound: true);
        m_TheaMain_Camera = m_TheaMain.FindAction("Camera", throwIfNotFound: true);
        m_TheaMain_Shot = m_TheaMain.FindAction("Shot", throwIfNotFound: true);
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

    // TheaMain
    private readonly InputActionMap m_TheaMain;
    private ITheaMainActions m_TheaMainActionsCallbackInterface;
    private readonly InputAction m_TheaMain_Run;
    private readonly InputAction m_TheaMain_Jump;
    private readonly InputAction m_TheaMain_Camera;
    private readonly InputAction m_TheaMain_Shot;
    public struct TheaMainActions
    {
        private @PlayerActions m_Wrapper;
        public TheaMainActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Run => m_Wrapper.m_TheaMain_Run;
        public InputAction @Jump => m_Wrapper.m_TheaMain_Jump;
        public InputAction @Camera => m_Wrapper.m_TheaMain_Camera;
        public InputAction @Shot => m_Wrapper.m_TheaMain_Shot;
        public InputActionMap Get() { return m_Wrapper.m_TheaMain; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TheaMainActions set) { return set.Get(); }
        public void SetCallbacks(ITheaMainActions instance)
        {
            if (m_Wrapper.m_TheaMainActionsCallbackInterface != null)
            {
                @Run.started -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnRun;
                @Jump.started -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnJump;
                @Camera.started -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnCamera;
                @Shot.started -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnShot;
                @Shot.performed -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnShot;
                @Shot.canceled -= m_Wrapper.m_TheaMainActionsCallbackInterface.OnShot;
            }
            m_Wrapper.m_TheaMainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @Shot.started += instance.OnShot;
                @Shot.performed += instance.OnShot;
                @Shot.canceled += instance.OnShot;
            }
        }
    }
    public TheaMainActions @TheaMain => new TheaMainActions(this);
    public interface ITheaMainActions
    {
        void OnRun(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnShot(InputAction.CallbackContext context);
    }
}
