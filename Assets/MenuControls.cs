// GENERATED AUTOMATICALLY FROM 'Assets/MenuControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MenuControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MenuControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MenuControls"",
    ""maps"": [
        {
            ""name"": ""InMenu"",
            ""id"": ""ed399de3-f940-470f-877a-4d181206a1a3"",
            ""actions"": [
                {
                    ""name"": ""D-Pad"",
                    ""type"": ""Value"",
                    ""id"": ""e70c346a-1db0-446f-8b45-4b295adca4b5"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LStick"",
                    ""type"": ""Value"",
                    ""id"": ""24aacb88-170a-4981-8172-251f98c19fdc"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RStick"",
                    ""type"": ""Value"",
                    ""id"": ""9a8a7977-5685-4baf-bbdd-228872c5c2f8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""North"",
                    ""type"": ""Value"",
                    ""id"": ""f2cb2600-9759-4530-a180-87f5ce1e9103"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""East"",
                    ""type"": ""Value"",
                    ""id"": ""fa947db2-77ea-41f7-9629-5209fc785a85"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""South"",
                    ""type"": ""Value"",
                    ""id"": ""6b535f13-24f2-4ebc-bd17-f75824c707c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""West"",
                    ""type"": ""Value"",
                    ""id"": ""6a3eb25a-e3d3-4a14-b672-83a2f40237b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftShoulder"",
                    ""type"": ""Value"",
                    ""id"": ""2a630783-9419-4799-ad56-e8c7835e3740"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightShoulder"",
                    ""type"": ""Value"",
                    ""id"": ""e15a2f11-0f88-42e1-9853-12977f981e36"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftTrigger"",
                    ""type"": ""Value"",
                    ""id"": ""8ae553db-5c6d-4e11-b074-44e007ac98bb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightTrigger"",
                    ""type"": ""Value"",
                    ""id"": ""77dc04aa-6c81-433d-b74c-9acf3c7da657"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Value"",
                    ""id"": ""0c5cff7b-a21f-44d2-8730-0c4e10936718"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Value"",
                    ""id"": ""62cf22a6-2a5b-41a9-b161-dc2b40d8c7e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a037b88d-37df-4b85-ba61-25bd943737a6"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D-Pad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1030ab3a-b664-4703-9c80-c32013e3700c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36b259ab-e03d-4434-80ae-e7a7962503ec"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3086031e-def5-4b84-8e7b-5995f7f8eb51"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""North"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd4f68e9-afc8-41ed-a54e-0908f8db87af"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""East"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be575d2b-6cb6-46b9-8a92-5f25aab84ccc"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""South"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4490e2bd-fb46-4116-8977-98087fcd561e"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""West"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2864549-ba1c-44a7-8315-ba9995bbe529"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftShoulder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d25da4f-996d-49ce-bfb6-bb21fd6ee2ea"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightShoulder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be1c5ac4-c5e4-4d3f-a8c0-ba48f7897ecd"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""479c23dd-4d1c-41d3-a672-c6ecf3213f3d"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70497e43-0458-40bc-b7c3-edd467f041d3"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74ea6432-c72b-487b-a0e9-49978dd7ce39"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // InMenu
        m_InMenu = asset.FindActionMap("InMenu", throwIfNotFound: true);
        m_InMenu_DPad = m_InMenu.FindAction("D-Pad", throwIfNotFound: true);
        m_InMenu_LStick = m_InMenu.FindAction("LStick", throwIfNotFound: true);
        m_InMenu_RStick = m_InMenu.FindAction("RStick", throwIfNotFound: true);
        m_InMenu_North = m_InMenu.FindAction("North", throwIfNotFound: true);
        m_InMenu_East = m_InMenu.FindAction("East", throwIfNotFound: true);
        m_InMenu_South = m_InMenu.FindAction("South", throwIfNotFound: true);
        m_InMenu_West = m_InMenu.FindAction("West", throwIfNotFound: true);
        m_InMenu_LeftShoulder = m_InMenu.FindAction("LeftShoulder", throwIfNotFound: true);
        m_InMenu_RightShoulder = m_InMenu.FindAction("RightShoulder", throwIfNotFound: true);
        m_InMenu_LeftTrigger = m_InMenu.FindAction("LeftTrigger", throwIfNotFound: true);
        m_InMenu_RightTrigger = m_InMenu.FindAction("RightTrigger", throwIfNotFound: true);
        m_InMenu_Start = m_InMenu.FindAction("Start", throwIfNotFound: true);
        m_InMenu_Select = m_InMenu.FindAction("Select", throwIfNotFound: true);
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

    // InMenu
    private readonly InputActionMap m_InMenu;
    private IInMenuActions m_InMenuActionsCallbackInterface;
    private readonly InputAction m_InMenu_DPad;
    private readonly InputAction m_InMenu_LStick;
    private readonly InputAction m_InMenu_RStick;
    private readonly InputAction m_InMenu_North;
    private readonly InputAction m_InMenu_East;
    private readonly InputAction m_InMenu_South;
    private readonly InputAction m_InMenu_West;
    private readonly InputAction m_InMenu_LeftShoulder;
    private readonly InputAction m_InMenu_RightShoulder;
    private readonly InputAction m_InMenu_LeftTrigger;
    private readonly InputAction m_InMenu_RightTrigger;
    private readonly InputAction m_InMenu_Start;
    private readonly InputAction m_InMenu_Select;
    public struct InMenuActions
    {
        private @MenuControls m_Wrapper;
        public InMenuActions(@MenuControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @DPad => m_Wrapper.m_InMenu_DPad;
        public InputAction @LStick => m_Wrapper.m_InMenu_LStick;
        public InputAction @RStick => m_Wrapper.m_InMenu_RStick;
        public InputAction @North => m_Wrapper.m_InMenu_North;
        public InputAction @East => m_Wrapper.m_InMenu_East;
        public InputAction @South => m_Wrapper.m_InMenu_South;
        public InputAction @West => m_Wrapper.m_InMenu_West;
        public InputAction @LeftShoulder => m_Wrapper.m_InMenu_LeftShoulder;
        public InputAction @RightShoulder => m_Wrapper.m_InMenu_RightShoulder;
        public InputAction @LeftTrigger => m_Wrapper.m_InMenu_LeftTrigger;
        public InputAction @RightTrigger => m_Wrapper.m_InMenu_RightTrigger;
        public InputAction @Start => m_Wrapper.m_InMenu_Start;
        public InputAction @Select => m_Wrapper.m_InMenu_Select;
        public InputActionMap Get() { return m_Wrapper.m_InMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InMenuActions set) { return set.Get(); }
        public void SetCallbacks(IInMenuActions instance)
        {
            if (m_Wrapper.m_InMenuActionsCallbackInterface != null)
            {
                @DPad.started -= m_Wrapper.m_InMenuActionsCallbackInterface.OnDPad;
                @DPad.performed -= m_Wrapper.m_InMenuActionsCallbackInterface.OnDPad;
                @DPad.canceled -= m_Wrapper.m_InMenuActionsCallbackInterface.OnDPad;
                @LStick.started -= m_Wrapper.m_InMenuActionsCallbackInterface.OnLStick;
                @LStick.performed -= m_Wrapper.m_InMenuActionsCallbackInterface.OnLStick;
                @LStick.canceled -= m_Wrapper.m_InMenuActionsCallbackInterface.OnLStick;
                @RStick.started -= m_Wrapper.m_InMenuActionsCallbackInterface.OnRStick;
                @RStick.performed -= m_Wrapper.m_InMenuActionsCallbackInterface.OnRStick;
                @RStick.canceled -= m_Wrapper.m_InMenuActionsCallbackInterface.OnRStick;
                @North.started -= m_Wrapper.m_InMenuActionsCallbackInterface.OnNorth;
                @North.performed -= m_Wrapper.m_InMenuActionsCallbackInterface.OnNorth;
                @North.canceled -= m_Wrapper.m_InMenuActionsCallbackInterface.OnNorth;
                @East.started -= m_Wrapper.m_InMenuActionsCallbackInterface.OnEast;
                @East.performed -= m_Wrapper.m_InMenuActionsCallbackInterface.OnEast;
                @East.canceled -= m_Wrapper.m_InMenuActionsCallbackInterface.OnEast;
                @South.started -= m_Wrapper.m_InMenuActionsCallbackInterface.OnSouth;
                @South.performed -= m_Wrapper.m_InMenuActionsCallbackInterface.OnSouth;
                @South.canceled -= m_Wrapper.m_InMenuActionsCallbackInterface.OnSouth;
                @West.started -= m_Wrapper.m_InMenuActionsCallbackInterface.OnWest;
                @West.performed -= m_Wrapper.m_InMenuActionsCallbackInterface.OnWest;
                @West.canceled -= m_Wrapper.m_InMenuActionsCallbackInterface.OnWest;
                @LeftShoulder.started -= m_Wrapper.m_InMenuActionsCallbackInterface.OnLeftShoulder;
                @LeftShoulder.performed -= m_Wrapper.m_InMenuActionsCallbackInterface.OnLeftShoulder;
                @LeftShoulder.canceled -= m_Wrapper.m_InMenuActionsCallbackInterface.OnLeftShoulder;
                @RightShoulder.started -= m_Wrapper.m_InMenuActionsCallbackInterface.OnRightShoulder;
                @RightShoulder.performed -= m_Wrapper.m_InMenuActionsCallbackInterface.OnRightShoulder;
                @RightShoulder.canceled -= m_Wrapper.m_InMenuActionsCallbackInterface.OnRightShoulder;
                @LeftTrigger.started -= m_Wrapper.m_InMenuActionsCallbackInterface.OnLeftTrigger;
                @LeftTrigger.performed -= m_Wrapper.m_InMenuActionsCallbackInterface.OnLeftTrigger;
                @LeftTrigger.canceled -= m_Wrapper.m_InMenuActionsCallbackInterface.OnLeftTrigger;
                @RightTrigger.started -= m_Wrapper.m_InMenuActionsCallbackInterface.OnRightTrigger;
                @RightTrigger.performed -= m_Wrapper.m_InMenuActionsCallbackInterface.OnRightTrigger;
                @RightTrigger.canceled -= m_Wrapper.m_InMenuActionsCallbackInterface.OnRightTrigger;
                @Start.started -= m_Wrapper.m_InMenuActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_InMenuActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_InMenuActionsCallbackInterface.OnStart;
                @Select.started -= m_Wrapper.m_InMenuActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_InMenuActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_InMenuActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_InMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DPad.started += instance.OnDPad;
                @DPad.performed += instance.OnDPad;
                @DPad.canceled += instance.OnDPad;
                @LStick.started += instance.OnLStick;
                @LStick.performed += instance.OnLStick;
                @LStick.canceled += instance.OnLStick;
                @RStick.started += instance.OnRStick;
                @RStick.performed += instance.OnRStick;
                @RStick.canceled += instance.OnRStick;
                @North.started += instance.OnNorth;
                @North.performed += instance.OnNorth;
                @North.canceled += instance.OnNorth;
                @East.started += instance.OnEast;
                @East.performed += instance.OnEast;
                @East.canceled += instance.OnEast;
                @South.started += instance.OnSouth;
                @South.performed += instance.OnSouth;
                @South.canceled += instance.OnSouth;
                @West.started += instance.OnWest;
                @West.performed += instance.OnWest;
                @West.canceled += instance.OnWest;
                @LeftShoulder.started += instance.OnLeftShoulder;
                @LeftShoulder.performed += instance.OnLeftShoulder;
                @LeftShoulder.canceled += instance.OnLeftShoulder;
                @RightShoulder.started += instance.OnRightShoulder;
                @RightShoulder.performed += instance.OnRightShoulder;
                @RightShoulder.canceled += instance.OnRightShoulder;
                @LeftTrigger.started += instance.OnLeftTrigger;
                @LeftTrigger.performed += instance.OnLeftTrigger;
                @LeftTrigger.canceled += instance.OnLeftTrigger;
                @RightTrigger.started += instance.OnRightTrigger;
                @RightTrigger.performed += instance.OnRightTrigger;
                @RightTrigger.canceled += instance.OnRightTrigger;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public InMenuActions @InMenu => new InMenuActions(this);
    public interface IInMenuActions
    {
        void OnDPad(InputAction.CallbackContext context);
        void OnLStick(InputAction.CallbackContext context);
        void OnRStick(InputAction.CallbackContext context);
        void OnNorth(InputAction.CallbackContext context);
        void OnEast(InputAction.CallbackContext context);
        void OnSouth(InputAction.CallbackContext context);
        void OnWest(InputAction.CallbackContext context);
        void OnLeftShoulder(InputAction.CallbackContext context);
        void OnRightShoulder(InputAction.CallbackContext context);
        void OnLeftTrigger(InputAction.CallbackContext context);
        void OnRightTrigger(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
}
