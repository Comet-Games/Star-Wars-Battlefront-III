// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""919ad626-97d5-4386-9dc9-6f14a323632d"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bb47f9cd-66b0-409f-9ba3-4be2ddee1d07"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""View"",
                    ""type"": ""PassThrough"",
                    ""id"": ""af720058-6034-4fe4-bc62-b0705c6dfad7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""918a95f3-37ba-4ddb-9978-57401599364a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""4d9c6066-4c6e-4f66-a005-910f22ae1c7e"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""17ec3081-78cc-48b7-b853-542acf5fdf19"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b68c0dbb-6bc9-4667-bcce-2f060e3d8b4c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""298c5d64-7f71-4856-bb98-0488f27c5287"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2b4085ea-00a0-4fdb-90b8-897d63549c22"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5e7fe592-6e6b-4594-beca-ba5de037546d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b88f59fd-f233-4e74-a2e3-1a7642b9b7f7"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone,ScaleVector2(x=20,y=20)"",
                    ""groups"": """",
                    ""action"": ""View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Actions"",
            ""id"": ""f02f669d-2ae7-489d-9022-2d787544f93f"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""f7b703c3-2785-48a3-9583-cc0df54eddb0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WalkingToggle"",
                    ""type"": ""Button"",
                    ""id"": ""d04bfe64-f7ea-4b37-bee0-760e43211faa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""5063eb7a-9c2f-4c2f-9e59-8377ee58057a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire1"",
                    ""type"": ""Button"",
                    ""id"": ""fb69cf2b-0574-47e4-93e6-84baaa729b48"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire1Hold"",
                    ""type"": ""Button"",
                    ""id"": ""fb35f3b3-f38e-4d74-95a4-1b35f139f1c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Block"",
                    ""type"": ""Button"",
                    ""id"": ""63c49437-5425-4067-acc5-44804972f819"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BlockReleased"",
                    ""type"": ""Button"",
                    ""id"": ""94602f88-bff4-4b1c-9a53-2e581737b4ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1b620920-e2b8-40e5-a254-60d2bfdae807"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36c24a6c-b9bc-426e-80a2-688e1801862c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2a1ce0f-9e4d-4182-a739-5fbca1d33e44"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WalkingToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2389bba8-fd29-498d-b1db-b2cdcfda32cf"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WalkingToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""335b39ad-7639-45ad-a413-8fc110e43547"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0c393a5-a9b8-497a-aa0f-42f66ed74d56"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0c4f79f-a4eb-4d2e-a8fb-b329218a85cf"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""813486c2-9abf-4164-9324-74838eafe0cb"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8fa4d78-62f8-4df8-b4e6-4d650bb953bc"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire1Hold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d55256e5-8c17-4f34-95b1-4e70768d5b4e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire1Hold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c342bc7b-096e-47b1-a26b-60933c8addce"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05965882-6c4b-487b-8dae-b71b2fd78e7c"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64206747-571a-4b89-b868-6fc8877f26e4"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BlockReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d128251-f69e-4dc8-86b0-71914eab5dc8"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BlockReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Movement = m_Movement.FindAction("Movement", throwIfNotFound: true);
        m_Movement_View = m_Movement.FindAction("View", throwIfNotFound: true);
        // Actions
        m_Actions = asset.FindActionMap("Actions", throwIfNotFound: true);
        m_Actions_Jump = m_Actions.FindAction("Jump", throwIfNotFound: true);
        m_Actions_WalkingToggle = m_Actions.FindAction("WalkingToggle", throwIfNotFound: true);
        m_Actions_Sprint = m_Actions.FindAction("Sprint", throwIfNotFound: true);
        m_Actions_Fire1 = m_Actions.FindAction("Fire1", throwIfNotFound: true);
        m_Actions_Fire1Hold = m_Actions.FindAction("Fire1Hold", throwIfNotFound: true);
        m_Actions_Block = m_Actions.FindAction("Block", throwIfNotFound: true);
        m_Actions_BlockReleased = m_Actions.FindAction("BlockReleased", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Movement;
    private readonly InputAction m_Movement_View;
    public struct MovementActions
    {
        private @PlayerInputActions m_Wrapper;
        public MovementActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Movement_Movement;
        public InputAction @View => m_Wrapper.m_Movement_View;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMovement;
                @View.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnView;
                @View.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnView;
                @View.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnView;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @View.started += instance.OnView;
                @View.performed += instance.OnView;
                @View.canceled += instance.OnView;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Actions
    private readonly InputActionMap m_Actions;
    private IActionsActions m_ActionsActionsCallbackInterface;
    private readonly InputAction m_Actions_Jump;
    private readonly InputAction m_Actions_WalkingToggle;
    private readonly InputAction m_Actions_Sprint;
    private readonly InputAction m_Actions_Fire1;
    private readonly InputAction m_Actions_Fire1Hold;
    private readonly InputAction m_Actions_Block;
    private readonly InputAction m_Actions_BlockReleased;
    public struct ActionsActions
    {
        private @PlayerInputActions m_Wrapper;
        public ActionsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Actions_Jump;
        public InputAction @WalkingToggle => m_Wrapper.m_Actions_WalkingToggle;
        public InputAction @Sprint => m_Wrapper.m_Actions_Sprint;
        public InputAction @Fire1 => m_Wrapper.m_Actions_Fire1;
        public InputAction @Fire1Hold => m_Wrapper.m_Actions_Fire1Hold;
        public InputAction @Block => m_Wrapper.m_Actions_Block;
        public InputAction @BlockReleased => m_Wrapper.m_Actions_BlockReleased;
        public InputActionMap Get() { return m_Wrapper.m_Actions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionsActions set) { return set.Get(); }
        public void SetCallbacks(IActionsActions instance)
        {
            if (m_Wrapper.m_ActionsActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnJump;
                @WalkingToggle.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnWalkingToggle;
                @WalkingToggle.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnWalkingToggle;
                @WalkingToggle.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnWalkingToggle;
                @Sprint.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnSprint;
                @Fire1.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnFire1;
                @Fire1.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnFire1;
                @Fire1.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnFire1;
                @Fire1Hold.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnFire1Hold;
                @Fire1Hold.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnFire1Hold;
                @Fire1Hold.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnFire1Hold;
                @Block.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnBlock;
                @Block.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnBlock;
                @Block.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnBlock;
                @BlockReleased.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnBlockReleased;
                @BlockReleased.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnBlockReleased;
                @BlockReleased.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnBlockReleased;
            }
            m_Wrapper.m_ActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @WalkingToggle.started += instance.OnWalkingToggle;
                @WalkingToggle.performed += instance.OnWalkingToggle;
                @WalkingToggle.canceled += instance.OnWalkingToggle;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Fire1.started += instance.OnFire1;
                @Fire1.performed += instance.OnFire1;
                @Fire1.canceled += instance.OnFire1;
                @Fire1Hold.started += instance.OnFire1Hold;
                @Fire1Hold.performed += instance.OnFire1Hold;
                @Fire1Hold.canceled += instance.OnFire1Hold;
                @Block.started += instance.OnBlock;
                @Block.performed += instance.OnBlock;
                @Block.canceled += instance.OnBlock;
                @BlockReleased.started += instance.OnBlockReleased;
                @BlockReleased.performed += instance.OnBlockReleased;
                @BlockReleased.canceled += instance.OnBlockReleased;
            }
        }
    }
    public ActionsActions @Actions => new ActionsActions(this);
    public interface IMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnView(InputAction.CallbackContext context);
    }
    public interface IActionsActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnWalkingToggle(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnFire1(InputAction.CallbackContext context);
        void OnFire1Hold(InputAction.CallbackContext context);
        void OnBlock(InputAction.CallbackContext context);
        void OnBlockReleased(InputAction.CallbackContext context);
    }
}
