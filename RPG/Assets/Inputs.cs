//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Inputs.inputactions
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

namespace GameInputs
{
    public partial class @Inputs: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Inputs()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""MainPlayer"",
            ""id"": ""782c2572-e34a-401e-ae9c-bced7d022064"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a9d53549-f923-46ba-a344-bd3c6cb645ea"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""9d60bb4b-d235-462b-a2b4-376fce08d38b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""8ecf58cb-1165-4227-9800-45f3e90088a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""cda7249b-1d68-4e5c-87c3-98b20d4123e8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dance"",
                    ""type"": ""Button"",
                    ""id"": ""07087cd0-db9e-410f-9180-c104a09324dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""fa6d0d9e-3ba6-44d9-8c11-1600d4ba141f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""d344bfcf-4f75-493c-8798-bb4bee5b1c61"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""175d3554-aaac-4280-851c-892f105d62a2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MiniMap"",
                    ""type"": ""Button"",
                    ""id"": ""cafcc36b-c268-42d5-b8ae-90cc5adb8b67"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""bceb3751-31fb-479c-9c47-6d9619595e87"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""feff997f-05c5-43a5-b3d3-dcfd8315e27e"",
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
                    ""id"": ""be734f34-86c6-4b22-8fde-176f5eb1b16a"",
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
                    ""id"": ""2170c04e-9f42-472d-b8d0-5773ac38ac7a"",
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
                    ""id"": ""9200ddb4-fe85-4ebb-9a81-c366c716ef19"",
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
                    ""id"": ""d3156693-20ef-4811-a588-96936d1a3ba3"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""183cdaa1-81ec-46b2-88f4-45b20dd3a38e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b934918-3b72-4ff0-b659-8a68ca1e0c27"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e912323-8394-4eae-98d2-937525f92beb"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c29d544-144e-467e-a611-f737997c3c36"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46bd2f27-6b60-42a5-9c2b-f90d9863b042"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37e7cda6-7a62-4680-9527-a8840a2914a3"",
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
                    ""id"": ""b48ad6cf-dc89-4ceb-9e0e-c005cefda994"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MiniMap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // MainPlayer
            m_MainPlayer = asset.FindActionMap("MainPlayer", throwIfNotFound: true);
            m_MainPlayer_Movement = m_MainPlayer.FindAction("Movement", throwIfNotFound: true);
            m_MainPlayer_Inventory = m_MainPlayer.FindAction("Inventory", throwIfNotFound: true);
            m_MainPlayer_Aim = m_MainPlayer.FindAction("Aim", throwIfNotFound: true);
            m_MainPlayer_Shoot = m_MainPlayer.FindAction("Shoot", throwIfNotFound: true);
            m_MainPlayer_Dance = m_MainPlayer.FindAction("Dance", throwIfNotFound: true);
            m_MainPlayer_Crouch = m_MainPlayer.FindAction("Crouch", throwIfNotFound: true);
            m_MainPlayer_Run = m_MainPlayer.FindAction("Run", throwIfNotFound: true);
            m_MainPlayer_Jump = m_MainPlayer.FindAction("Jump", throwIfNotFound: true);
            m_MainPlayer_MiniMap = m_MainPlayer.FindAction("MiniMap", throwIfNotFound: true);
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

        // MainPlayer
        private readonly InputActionMap m_MainPlayer;
        private List<IMainPlayerActions> m_MainPlayerActionsCallbackInterfaces = new List<IMainPlayerActions>();
        private readonly InputAction m_MainPlayer_Movement;
        private readonly InputAction m_MainPlayer_Inventory;
        private readonly InputAction m_MainPlayer_Aim;
        private readonly InputAction m_MainPlayer_Shoot;
        private readonly InputAction m_MainPlayer_Dance;
        private readonly InputAction m_MainPlayer_Crouch;
        private readonly InputAction m_MainPlayer_Run;
        private readonly InputAction m_MainPlayer_Jump;
        private readonly InputAction m_MainPlayer_MiniMap;
        public struct MainPlayerActions
        {
            private @Inputs m_Wrapper;
            public MainPlayerActions(@Inputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_MainPlayer_Movement;
            public InputAction @Inventory => m_Wrapper.m_MainPlayer_Inventory;
            public InputAction @Aim => m_Wrapper.m_MainPlayer_Aim;
            public InputAction @Shoot => m_Wrapper.m_MainPlayer_Shoot;
            public InputAction @Dance => m_Wrapper.m_MainPlayer_Dance;
            public InputAction @Crouch => m_Wrapper.m_MainPlayer_Crouch;
            public InputAction @Run => m_Wrapper.m_MainPlayer_Run;
            public InputAction @Jump => m_Wrapper.m_MainPlayer_Jump;
            public InputAction @MiniMap => m_Wrapper.m_MainPlayer_MiniMap;
            public InputActionMap Get() { return m_Wrapper.m_MainPlayer; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MainPlayerActions set) { return set.Get(); }
            public void AddCallbacks(IMainPlayerActions instance)
            {
                if (instance == null || m_Wrapper.m_MainPlayerActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_MainPlayerActionsCallbackInterfaces.Add(instance);
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Dance.started += instance.OnDance;
                @Dance.performed += instance.OnDance;
                @Dance.canceled += instance.OnDance;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MiniMap.started += instance.OnMiniMap;
                @MiniMap.performed += instance.OnMiniMap;
                @MiniMap.canceled += instance.OnMiniMap;
            }

            private void UnregisterCallbacks(IMainPlayerActions instance)
            {
                @Movement.started -= instance.OnMovement;
                @Movement.performed -= instance.OnMovement;
                @Movement.canceled -= instance.OnMovement;
                @Inventory.started -= instance.OnInventory;
                @Inventory.performed -= instance.OnInventory;
                @Inventory.canceled -= instance.OnInventory;
                @Aim.started -= instance.OnAim;
                @Aim.performed -= instance.OnAim;
                @Aim.canceled -= instance.OnAim;
                @Shoot.started -= instance.OnShoot;
                @Shoot.performed -= instance.OnShoot;
                @Shoot.canceled -= instance.OnShoot;
                @Dance.started -= instance.OnDance;
                @Dance.performed -= instance.OnDance;
                @Dance.canceled -= instance.OnDance;
                @Crouch.started -= instance.OnCrouch;
                @Crouch.performed -= instance.OnCrouch;
                @Crouch.canceled -= instance.OnCrouch;
                @Run.started -= instance.OnRun;
                @Run.performed -= instance.OnRun;
                @Run.canceled -= instance.OnRun;
                @Jump.started -= instance.OnJump;
                @Jump.performed -= instance.OnJump;
                @Jump.canceled -= instance.OnJump;
                @MiniMap.started -= instance.OnMiniMap;
                @MiniMap.performed -= instance.OnMiniMap;
                @MiniMap.canceled -= instance.OnMiniMap;
            }

            public void RemoveCallbacks(IMainPlayerActions instance)
            {
                if (m_Wrapper.m_MainPlayerActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IMainPlayerActions instance)
            {
                foreach (var item in m_Wrapper.m_MainPlayerActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_MainPlayerActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public MainPlayerActions @MainPlayer => new MainPlayerActions(this);
        public interface IMainPlayerActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnInventory(InputAction.CallbackContext context);
            void OnAim(InputAction.CallbackContext context);
            void OnShoot(InputAction.CallbackContext context);
            void OnDance(InputAction.CallbackContext context);
            void OnCrouch(InputAction.CallbackContext context);
            void OnRun(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnMiniMap(InputAction.CallbackContext context);
        }
    }
}
