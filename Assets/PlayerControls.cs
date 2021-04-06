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
                    ""type"": ""Value"",
                    ""id"": ""ad55b402-c17c-4cca-9885-b170fc557d42"",
                    ""expectedControlType"": """",
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
                },
                {
                    ""name"": ""Audio"",
                    ""type"": ""Button"",
                    ""id"": ""21b6241e-9d6c-46bd-b4c0-65bd7eef984e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Audio2"",
                    ""type"": ""Button"",
                    ""id"": ""706fd83c-99ca-43a9-ad4c-72672d7217f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SceneTwo"",
                    ""type"": ""Button"",
                    ""id"": ""00c68fad-f372-40fb-9f5b-573b63a14a5e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SceneThree"",
                    ""type"": ""Button"",
                    ""id"": ""39d7a2e8-4c53-45b2-aa7d-e0fb161d2cf2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScneFour"",
                    ""type"": ""Button"",
                    ""id"": ""df5f832d-cff6-4a4b-a3b2-b9661a0e44f5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SceneFive"",
                    ""type"": ""Button"",
                    ""id"": ""0ab9f5b5-8c57-466d-96b7-a36484b45517"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SongOne"",
                    ""type"": ""Button"",
                    ""id"": ""e143d91b-4fea-4e33-915b-f17bbfd464c1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SongTwo"",
                    ""type"": ""Button"",
                    ""id"": ""127d9602-957e-4304-9087-e03627d34221"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SongThree"",
                    ""type"": ""Button"",
                    ""id"": ""355713f3-3f64-4ede-adaa-5260e33851f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SongFour"",
                    ""type"": ""Button"",
                    ""id"": ""72013fac-e44d-4dc5-8486-aef2586c46db"",
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
                    ""path"": ""<Gamepad>/rightStick"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""46bd558b-cdc8-4bdb-9e27-1347c27a067b"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Audio"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e10068e-1afa-4000-b528-47628e5af063"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Audio2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc9693a4-b919-48d7-8f4f-5260a862e347"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SceneTwo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb62c312-23d2-4d3b-b5b4-44bc32ced116"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SceneThree"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db6c75d4-679a-48d7-96b5-1bbbc012480e"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ScneFour"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c3620b1-5f9e-44b1-b32e-ed4ef51a5151"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SceneFive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b50510d1-75ef-4f46-8082-cfdf75759320"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SongOne"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1174ec7a-36fe-4c8f-a6f0-da2ccc281936"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SongTwo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bed2c49b-53dc-414b-979d-10dfc0222931"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SongThree"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2fa9e254-602e-4b02-b118-6f76f30eff7d"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SongFour"",
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
        m_Gameplay_Audio = m_Gameplay.FindAction("Audio", throwIfNotFound: true);
        m_Gameplay_Audio2 = m_Gameplay.FindAction("Audio2", throwIfNotFound: true);
        m_Gameplay_SceneTwo = m_Gameplay.FindAction("SceneTwo", throwIfNotFound: true);
        m_Gameplay_SceneThree = m_Gameplay.FindAction("SceneThree", throwIfNotFound: true);
        m_Gameplay_ScneFour = m_Gameplay.FindAction("ScneFour", throwIfNotFound: true);
        m_Gameplay_SceneFive = m_Gameplay.FindAction("SceneFive", throwIfNotFound: true);
        m_Gameplay_SongOne = m_Gameplay.FindAction("SongOne", throwIfNotFound: true);
        m_Gameplay_SongTwo = m_Gameplay.FindAction("SongTwo", throwIfNotFound: true);
        m_Gameplay_SongThree = m_Gameplay.FindAction("SongThree", throwIfNotFound: true);
        m_Gameplay_SongFour = m_Gameplay.FindAction("SongFour", throwIfNotFound: true);
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
    private readonly InputAction m_Gameplay_Audio;
    private readonly InputAction m_Gameplay_Audio2;
    private readonly InputAction m_Gameplay_SceneTwo;
    private readonly InputAction m_Gameplay_SceneThree;
    private readonly InputAction m_Gameplay_ScneFour;
    private readonly InputAction m_Gameplay_SceneFive;
    private readonly InputAction m_Gameplay_SongOne;
    private readonly InputAction m_Gameplay_SongTwo;
    private readonly InputAction m_Gameplay_SongThree;
    private readonly InputAction m_Gameplay_SongFour;
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
        public InputAction @Audio => m_Wrapper.m_Gameplay_Audio;
        public InputAction @Audio2 => m_Wrapper.m_Gameplay_Audio2;
        public InputAction @SceneTwo => m_Wrapper.m_Gameplay_SceneTwo;
        public InputAction @SceneThree => m_Wrapper.m_Gameplay_SceneThree;
        public InputAction @ScneFour => m_Wrapper.m_Gameplay_ScneFour;
        public InputAction @SceneFive => m_Wrapper.m_Gameplay_SceneFive;
        public InputAction @SongOne => m_Wrapper.m_Gameplay_SongOne;
        public InputAction @SongTwo => m_Wrapper.m_Gameplay_SongTwo;
        public InputAction @SongThree => m_Wrapper.m_Gameplay_SongThree;
        public InputAction @SongFour => m_Wrapper.m_Gameplay_SongFour;
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
                @Audio.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAudio;
                @Audio.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAudio;
                @Audio.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAudio;
                @Audio2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAudio2;
                @Audio2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAudio2;
                @Audio2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAudio2;
                @SceneTwo.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSceneTwo;
                @SceneTwo.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSceneTwo;
                @SceneTwo.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSceneTwo;
                @SceneThree.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSceneThree;
                @SceneThree.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSceneThree;
                @SceneThree.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSceneThree;
                @ScneFour.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnScneFour;
                @ScneFour.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnScneFour;
                @ScneFour.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnScneFour;
                @SceneFive.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSceneFive;
                @SceneFive.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSceneFive;
                @SceneFive.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSceneFive;
                @SongOne.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSongOne;
                @SongOne.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSongOne;
                @SongOne.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSongOne;
                @SongTwo.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSongTwo;
                @SongTwo.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSongTwo;
                @SongTwo.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSongTwo;
                @SongThree.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSongThree;
                @SongThree.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSongThree;
                @SongThree.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSongThree;
                @SongFour.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSongFour;
                @SongFour.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSongFour;
                @SongFour.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSongFour;
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
                @Audio.started += instance.OnAudio;
                @Audio.performed += instance.OnAudio;
                @Audio.canceled += instance.OnAudio;
                @Audio2.started += instance.OnAudio2;
                @Audio2.performed += instance.OnAudio2;
                @Audio2.canceled += instance.OnAudio2;
                @SceneTwo.started += instance.OnSceneTwo;
                @SceneTwo.performed += instance.OnSceneTwo;
                @SceneTwo.canceled += instance.OnSceneTwo;
                @SceneThree.started += instance.OnSceneThree;
                @SceneThree.performed += instance.OnSceneThree;
                @SceneThree.canceled += instance.OnSceneThree;
                @ScneFour.started += instance.OnScneFour;
                @ScneFour.performed += instance.OnScneFour;
                @ScneFour.canceled += instance.OnScneFour;
                @SceneFive.started += instance.OnSceneFive;
                @SceneFive.performed += instance.OnSceneFive;
                @SceneFive.canceled += instance.OnSceneFive;
                @SongOne.started += instance.OnSongOne;
                @SongOne.performed += instance.OnSongOne;
                @SongOne.canceled += instance.OnSongOne;
                @SongTwo.started += instance.OnSongTwo;
                @SongTwo.performed += instance.OnSongTwo;
                @SongTwo.canceled += instance.OnSongTwo;
                @SongThree.started += instance.OnSongThree;
                @SongThree.performed += instance.OnSongThree;
                @SongThree.canceled += instance.OnSongThree;
                @SongFour.started += instance.OnSongFour;
                @SongFour.performed += instance.OnSongFour;
                @SongFour.canceled += instance.OnSongFour;
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
        void OnAudio(InputAction.CallbackContext context);
        void OnAudio2(InputAction.CallbackContext context);
        void OnSceneTwo(InputAction.CallbackContext context);
        void OnSceneThree(InputAction.CallbackContext context);
        void OnScneFour(InputAction.CallbackContext context);
        void OnSceneFive(InputAction.CallbackContext context);
        void OnSongOne(InputAction.CallbackContext context);
        void OnSongTwo(InputAction.CallbackContext context);
        void OnSongThree(InputAction.CallbackContext context);
        void OnSongFour(InputAction.CallbackContext context);
    }
    public interface IKleurActions
    {
        void OnRondje(InputAction.CallbackContext context);
        void OnKruisje(InputAction.CallbackContext context);
        void OnVierkantje(InputAction.CallbackContext context);
        void OnDriehoekje(InputAction.CallbackContext context);
    }
}
