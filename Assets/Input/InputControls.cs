// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControls"",
    ""maps"": [
        {
            ""name"": ""Paddle"",
            ""id"": ""1e05d267-cecc-409e-a509-e2039568d89e"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""81238f0f-06d0-4659-a559-3614179c19fd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Tap"",
                    ""type"": ""Button"",
                    ""id"": ""845bb59e-e44e-4a12-9781-4886a5a867fb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""9a5d66f8-988f-4137-95a4-9eeef83cebe9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2c0577f2-86d3-4408-9138-984ce7172695"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85758399-2677-4514-bc05-31df3d3d1262"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9bb46c8-b22f-4a11-9d4b-287b47bd4288"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""527c5b42-dbd0-4aa9-b9c8-ec192334696d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b82c470-2d9d-4cbd-a8e6-630abf2e8954"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Paddle
        m_Paddle = asset.FindActionMap("Paddle", throwIfNotFound: true);
        m_Paddle_Move = m_Paddle.FindAction("Move", throwIfNotFound: true);
        m_Paddle_Tap = m_Paddle.FindAction("Tap", throwIfNotFound: true);
        m_Paddle_Pause = m_Paddle.FindAction("Pause", throwIfNotFound: true);
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

    // Paddle
    private readonly InputActionMap m_Paddle;
    private IPaddleActions m_PaddleActionsCallbackInterface;
    private readonly InputAction m_Paddle_Move;
    private readonly InputAction m_Paddle_Tap;
    private readonly InputAction m_Paddle_Pause;
    public struct PaddleActions
    {
        private @InputControls m_Wrapper;
        public PaddleActions(@InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Paddle_Move;
        public InputAction @Tap => m_Wrapper.m_Paddle_Tap;
        public InputAction @Pause => m_Wrapper.m_Paddle_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Paddle; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PaddleActions set) { return set.Get(); }
        public void SetCallbacks(IPaddleActions instance)
        {
            if (m_Wrapper.m_PaddleActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PaddleActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PaddleActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PaddleActionsCallbackInterface.OnMove;
                @Tap.started -= m_Wrapper.m_PaddleActionsCallbackInterface.OnTap;
                @Tap.performed -= m_Wrapper.m_PaddleActionsCallbackInterface.OnTap;
                @Tap.canceled -= m_Wrapper.m_PaddleActionsCallbackInterface.OnTap;
                @Pause.started -= m_Wrapper.m_PaddleActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PaddleActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PaddleActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PaddleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Tap.started += instance.OnTap;
                @Tap.performed += instance.OnTap;
                @Tap.canceled += instance.OnTap;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public PaddleActions @Paddle => new PaddleActions(this);
    public interface IPaddleActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnTap(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
