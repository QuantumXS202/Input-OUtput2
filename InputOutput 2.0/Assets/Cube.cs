using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class Cube : MonoBehaviour
{
    public Material myMaterial;

    PlayerControls controls;

    Vector2 move;

    Gamepad gamepad;

    public float position;

    public AudioSource audioSource;

    public AudioSource audioSource1;

    public AudioSource audioSource2;

    public AudioSource audioSource3;

    public AudioSource audioSource4;

    void Awake()
    {
        controls = new PlayerControls();

        controls.Gameplay.Grow.performed += ctx => Groei();
        controls.Gameplay.Smaller.performed += ctx => Kleiner();
        controls.Gameplay.DraaiLinks.performed += ctx => DraaiLinks();
        controls.Gameplay.DraaiRechts.performed += ctx => DraaiRechts();
        controls.Gameplay.DraaiOmhoog.performed += ctx => DraaiOmhoog();
        controls.Gameplay.DraaiOmlaag.performed += ctx => DraaiOmlaag();
        controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => move = Vector2.zero;
        controls.Gameplay.Reload.performed += ctx => Reload();
        controls.Gameplay.Rumble.performed += ctx => Rumble();
        controls.Gameplay.StopRumble.performed += ctx => StopRumble();
        controls.Gameplay.Audio.performed += ctx => Audio();
        controls.Gameplay.SceneTwo.performed += ctx => SceneTwo();
        controls.Gameplay.SceneThree.performed += ctx => SceneThree();
        controls.Gameplay.ScneFour.performed += ctx => SceneFour();
        controls.Gameplay.SceneFive.performed += ctx => SceneFive();
        controls.Gameplay.SceneReload.performed += ctx => SceneReload();
        controls.Gameplay.SongOne.performed += ctx => SongOne();
        controls.Gameplay.SongTwo.performed += ctx => SongTwo();
        controls.Gameplay.SongThree.performed += ctx => SongThree();
        controls.Gameplay.SongFour.performed += ctx => SongFour();
    }

    void Update()                                                   
    {
        Vector2 m = new Vector2(move.x, move.y) * Time.deltaTime;
        transform.Translate(m, Space.World);
    }

    void Groei()
    {
        transform.localScale *= 1.1f;
    }

    void Kleiner()
    {
        transform.localScale *= 0.9f;
    }

    void DraaiLinks()
    {
      transform.Rotate(new Vector3(0f, 0f, 2f));
    }

    void DraaiRechts()
    {
       transform.Rotate(new Vector3(0f, 0f, -2f));
    }

    void DraaiOmhoog()
    {
        transform.Rotate(new Vector3(0f, 2f, 0f));
    }

    void DraaiOmlaag()
    {
        transform.Rotate(new Vector3(0f, -2f, 0f));
    }

    void Reload()
    {
        SceneManager.LoadScene("SampleScene");
    }

    void Rumble()
    {
        Gamepad.current.SetMotorSpeeds(1f, 1f);
    }

    void StopRumble()
    {
        Gamepad.current.SetMotorSpeeds(0f, 0f);
    }

    void Audio()
    {
        audioSource.Play();                                                                                    
    }

    void SceneTwo()
    {
        SceneManager.LoadScene("Scene1");
    }

    void SceneThree()
    {
        SceneManager.LoadScene("Scene2");
    }

    void SceneFour()
    {
        SceneManager.LoadScene("Scene3");
    }

    void SceneFive()
    {
        SceneManager.LoadScene("Scene4");
    }

    void SceneReload()
    {

    }

    void SongOne()
    {
        audioSource1.Play();
    }

    void SongTwo()
    {
        audioSource2.Play();
    }

    void SongThree()
    {
        audioSource3.Play();
    }

    void SongFour()
    {
        audioSource4.Play();
    }

    void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    void OnDisable()
    {
        controls.Gameplay.Disable();
    }
}
