// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""64bacee7-2af2-4d83-aa3f-29d5d9c28df7"",
            ""actions"": [
                {
                    ""name"": ""Grow"",
                    ""type"": ""Button"",
                    ""id"": ""bd19894f-e989-402d-b104-31a733fbc899"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DraaiLinks"",
                    ""type"": ""Button"",
                    ""id"": ""598b3d90-f797-4457-9e2f-3804ba9c9443"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DraaiRechts"",
                    ""type"": ""Button"",
                    ""id"": ""8f604f2b-5b94-4d86-9e13-05a9a9a47874"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DraaiOmhoog"",
                    ""type"": ""Button"",
                    ""id"": ""4a541631-23fa-4da2-a7fe-d050bb6649f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DraaiOmlaag"",
                    ""type"": ""Button"",
                    ""id"": ""5154dbbf-9829-4252-962c-e3b1e3460c08"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Smaller"",
                    ""type"": ""Button"",
                    ""id"": ""2ce287d8-bf96-4345-bb51-e2c02122942e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""ad55b402-c17c-4cca-9885-b170fc557d42"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Button"",
                    ""id"": ""7f0a4f9c-8cb6-4074-87b7-dabfa1a0da30"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""bea143d3-4b3d-40b9-ac81-6ae54235394f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rumble"",
                    ""type"": ""Button"",
                    ""id"": ""defeea23-821f-45b5-bc76-cc81c903ee30"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StopRumble"",
                    ""type"": ""Button"",
                    ""id"": ""ced33c15-098b-4fc5-be28-35e8435a1261"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d6ad3afd-8b01-485b-a1c7-dd763965095c"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a98778e0-0f6c-487d-b5ef-0210b98c37ff"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DraaiLinks"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60667a45-9d60-439f-89df-0aa788339aea"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DraaiRechts"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b058ddd-a5bd-468a-a785-9c748f439117"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DraaiOmhoog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d09cb184-5082-4ead-bde0-a8096a2f39f3"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DraaiOmlaag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""768897b5-a782-4499-bd86-dddab0602950"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Smaller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a9c5f71-2cf1-4342-a8e8-c11cd91c9da0"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d183bf2-1314-48ba-bc7a-0471cb26c2cc"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ed6bed2-2bcc-4cbf-92c6-3f5983755838"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""06c0c683-54ce-440f-8de6-0ab4dc156089"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rumble"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d939226-b48a-4fb9-8c99-9130e4cca42d"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StopRumble"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Kleur"",
            ""id"": ""1be9c237-94b7-4ede-aed3-d00630528cde"",
            ""actions"": [
                {
                    ""name"": ""Rondje"",
                    ""type"": ""Button"",
                    ""id"": ""c26bdc5e-324a-4837-89d3-edfbef0087af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Kruisje"",
                    ""type"": ""Button"",
                    ""id"": ""e8fa7fc3-5780-47c9-b548-f57f97d0b11b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vierkantje"",
                    ""type"": ""Button"",
                    ""id"": ""2c45217f-a56f-4175-afc8-6ab48e40805a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Driehoekje"",
                    ""type"": ""Button"",
                    ""id"": ""9e342742-ccc6-4052-9687-e1c33ed9603e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6e16ed3b-fbbb-4481-aa36-3d66c477d737"",
                    ""path"": ""<HID::Sony Interactive Entertainment Controller>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rondje"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""746ae030-b39d-42e1-b995-387080dcd16b"",
                    ""path"": ""<HID::Sony Interactive Entertainment Controller>/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Kruisje"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""322b3aba-14a8-4d4c-9916-9ee6a2dddd45"",
                    ""path"": ""<HID::Sony Interactive Entertainment Controller>/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vierkantje"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b349f3a4-14a5-4d79-a150-fddc18f29713"",
                    ""path"": ""<HID::Sony Interactive Entertainment Controller>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Driehoekje"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Grow = m_Gameplay.FindAction("Grow", throwIfNotFound: true);
        m_Gameplay_DraaiLinks = m_Gameplay.FindAction("DraaiLinks", throwIfNotFound: true);
        m_Gameplay_DraaiRechts = m_Gameplay.FindAction("DraaiRechts", throwIfNotFound: true);
        m_Gameplay_DraaiOmhoog = m_Gameplay.FindAction("DraaiOmhoog", throwIfNotFound: true);
        m_Gameplay_DraaiOmlaag = m_Gameplay.FindAction("DraaiOmlaag", throwIfNotFound: true);
        m_Gameplay_Smaller = m_Gameplay.FindAction("Smaller", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Rotation = m_Gameplay.FindAction("Rotation", throwIfNotFound: true);
        m_Gameplay_Reload = m_Gameplay.FindAction("Reload", throwIfNotFound: true);
        m_Gameplay_Rumble = m_Gameplay.FindAction("Rumble", throwIfNotFound: true);
        m_Gameplay_StopRumble = m_Gameplay.FindAction("StopRumble", throwIfNotFound: true);
        // Kleur
        m_Kleur = asset.FindActionMap("Kleur", throwIfNotFound: true);
        m_Kleur_Rondje = m_Kleur.FindAction("Rondje", throwIfNotFound: true);
        m_Kleur_Kruisje = m_Kleur.FindAction("Kruisje", throwIfNotFound: true);
        m_Kleur_Vierkantje = m_Kleur.FindAction("Vierkantje", throwIfNotFound: true);
        m_Kleur_Driehoekje = m_Kleur.FindAction("Driehoekje", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Grow;
    private readonly InputAction m_Gameplay_DraaiLinks;
    private readonly InputAction m_Gameplay_DraaiRechts;
    private readonly InputAction m_Gameplay_DraaiOmhoog;
    private readonly InputAction m_Gameplay_DraaiOmlaag;
    private readonly InputAction m_Gameplay_Smaller;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Rotation;
    private readonly InputAction m_Gameplay_Reload;
    private readonly InputAction m_Gameplay_Rumble;
    private readonly InputAction m_Gameplay_StopRumble;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grow => m_Wrapper.m_Gameplay_Grow;
        public InputAction @DraaiLinks => m_Wrapper.m_Gameplay_DraaiLinks;
        public InputAction @DraaiRechts => m_Wrapper.m_Gameplay_DraaiRechts;
        public InputAction @DraaiOmhoog => m_Wrapper.m_Gameplay_DraaiOmhoog;
        public InputAction @DraaiOmlaag => m_Wrapper.m_Gameplay_DraaiOmlaag;
        public InputAction @Smaller => m_Wrapper.m_Gameplay_Smaller;
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Rotation => m_Wrapper.m_Gameplay_Rotation;
        public InputAction @Reload => m_Wrapper.m_Gameplay_Reload;
        public InputAction @Rumble => m_Wrapper.m_Gameplay_Rumble;
        public InputAction @StopRumble => m_Wrapper.m_Gameplay_StopRumble;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Grow.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                @Grow.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                @Grow.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                @DraaiLinks.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDraaiLinks;
                @DraaiLinks.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDraaiLinks;
                @DraaiLinks.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDraaiLinks;
                @DraaiRechts.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDraaiRechts;
                @DraaiRechts.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDraaiRechts;
                @DraaiRechts.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDraaiRechts;
                @DraaiOmhoog.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDraaiOmhoog;
                @DraaiOmhoog.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDraaiOmhoog;
                @DraaiOmhoog.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDraaiOmhoog;
                @DraaiOmlaag.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDraaiOmlaag;
                @DraaiOmlaag.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDraaiOmlaag;
                @DraaiOmlaag.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDraaiOmlaag;
                @Smaller.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSmaller;
                @Smaller.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSmaller;
                @Smaller.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSmaller;
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Rotation.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotation;
                @Reload.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReload;
                @Rumble.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRumble;
                @Rumble.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRumble;
                @Rumble.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRumble;
                @StopRumble.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStopRumble;
                @StopRumble.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStopRumble;
                @StopRumble.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStopRumble;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Grow.started += instance.OnGrow;
                @Grow.performed += instance.OnGrow;
                @Grow.canceled += instance.OnGrow;
                @DraaiLinks.started += instance.OnDraaiLinks;
                @DraaiLinks.performed += instance.OnDraaiLinks;
                @DraaiLinks.canceled += instance.OnDraaiLinks;
                @DraaiRechts.started += instance.OnDraaiRechts;
                @DraaiRechts.performed += instance.OnDraaiRechts;
                @DraaiRechts.canceled += instance.OnDraaiRechts;
                @DraaiOmhoog.started += instance.OnDraaiOmhoog;
                @DraaiOmhoog.performed += instance.OnDraaiOmhoog;
                @DraaiOmhoog.canceled += instance.OnDraaiOmhoog;
                @DraaiOmlaag.started += instance.OnDraaiOmlaag;
                @DraaiOmlaag.performed += instance.OnDraaiOmlaag;
                @DraaiOmlaag.canceled += instance.OnDraaiOmlaag;
                @Smaller.started += instance.OnSmaller;
                @Smaller.performed += instance.OnSmaller;
                @Smaller.canceled += instance.OnSmaller;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @Rumble.started += instance.OnRumble;
                @Rumble.performed += instance.OnRumble;
                @Rumble.canceled += instance.OnRumble;
                @StopRumble.started += instance.OnStopRumble;
                @StopRumble.performed += instance.OnStopRumble;
                @StopRumble.canceled += instance.OnStopRumble;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Kleur
    private readonly InputActionMap m_Kleur;
    private IKleurActions m_KleurActionsCallbackInterface;
    private readonly InputAction m_Kleur_Rondje;
    private readonly InputAction m_Kleur_Kruisje;
    private readonly InputAction m_Kleur_Vierkantje;
    private readonly InputAction m_Kleur_Driehoekje;
    public struct KleurActions
    {
        private @PlayerControls m_Wrapper;
        public KleurActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rondje => m_Wrapper.m_Kleur_Rondje;
        public InputAction @Kruisje => m_Wrapper.m_Kleur_Kruisje;
        public InputAction @Vierkantje => m_Wrapper.m_Kleur_Vierkantje;
        public InputAction @Driehoekje => m_Wrapper.m_Kleur_Driehoekje;
        public InputActionMap Get() { return m_Wrapper.m_Kleur; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KleurActions set) { return set.Get(); }
        public void SetCallbacks(IKleurActions instance)
        {
            if (m_Wrapper.m_KleurActionsCallbackInterface != null)
            {
                @Rondje.started -= m_Wrapper.m_KleurActionsCallbackInterface.OnRondje;
                @Rondje.performed -= m_Wrapper.m_KleurActionsCallbackInterface.OnRondje;
                @Rondje.canceled -= m_Wrapper.m_KleurActionsCallbackInterface.OnRondje;
                @Kruisje.started -= m_Wrapper.m_KleurActionsCallbackInterface.OnKruisje;
                @Kruisje.performed -= m_Wrapper.m_KleurActionsCallbackInterface.OnKruisje;
                @Kruisje.canceled -= m_Wrapper.m_KleurActionsCallbackInterface.OnKruisje;
                @Vierkantje.started -= m_Wrapper.m_KleurActionsCallbackInterface.OnVierkantje;
                @Vierkantje.performed -= m_Wrapper.m_KleurActionsCallbackInterface.OnVierkantje;
                @Vierkantje.canceled -= m_Wrapper.m_KleurActionsCallbackInterface.OnVierkantje;
                @Driehoekje.started -= m_Wrapper.m_KleurActionsCallbackInterface.OnDriehoekje;
                @Driehoekje.performed -= m_Wrapper.m_KleurActionsCallbackInterface.OnDriehoekje;
                @Driehoekje.canceled -= m_Wrapper.m_KleurActionsCallbackInterface.OnDriehoekje;
            }
            m_Wrapper.m_KleurActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rondje.started += instance.OnRondje;
                @Rondje.performed += instance.OnRondje;
                @Rondje.canceled += instance.OnRondje;
                @Kruisje.started += instance.OnKruisje;
                @Kruisje.performed += instance.OnKruisje;
                @Kruisje.canceled += instance.OnKruisje;
                @Vierkantje.started += instance.OnVierkantje;
                @Vierkantje.performed += instance.OnVierkantje;
                @Vierkantje.canceled += instance.OnVierkantje;
                @Driehoekje.started += instance.OnDriehoekje;
                @Driehoekje.performed += instance.OnDriehoekje;
                @Driehoekje.canceled += instance.OnDriehoekje;
            }
        }
    }
    public KleurActions @Kleur => new KleurActions(this);
    public interface IGameplayActions
    {
        void OnGrow(InputAction.CallbackContext context);
        void OnDraaiLinks(InputAction.CallbackContext context);
        void OnDraaiRechts(InputAction.CallbackContext context);
        void OnDraaiOmhoog(InputAction.CallbackContext context);
        void OnDraaiOmlaag(InputAction.CallbackContext context);
        void OnSmaller(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnRumble(InputAction.CallbackContext context);
        void OnStopRumble(InputAction.CallbackContext context);
    }
    public interface IKleurActions
    {
        void OnRondje(InputAction.CallbackContext context);
        void OnKruisje(InputAction.CallbackContext context);
        void OnVierkantje(InputAction.CallbackContext context);
        void OnDriehoekje(InputAction.CallbackContext context);
    }
}
