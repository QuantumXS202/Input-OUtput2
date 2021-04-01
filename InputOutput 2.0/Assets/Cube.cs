﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class Cube : MonoBehaviour
{
    public Material myMaterial;

    PlayerControls controls;

    Vector2 move;
    
    void Awake()
    {
        controls = new PlayerControls();

        controls.Gameplay.Grow.performed += ctx => Groei();
        controls.Gameplay.Smaller.performed += ctx => Kleiner();
        controls.Gameplay.DraaiLinks.performed += ctx => DraaiLinks();
        controls.Gameplay.DraaiRechts.performed += ctx => DraaiRechts();
        controls.Gameplay.DraaiOmhoog.performed += ctx => DraaiOmhoog();
        controls.Gameplay.DraaiOmlaag.performed += ctx => DraaiOmlaag();
        controls.Kleur.Rondje.performed += ctx => KleurRondje();
        controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => move = Vector2.zero;
        controls.Gameplay.Reload.performed += ctx => Reload();
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

    void KleurRondje()
    {
        
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

    void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    void OnDisable()
    {
        controls.Gameplay.Disable();
    }
}
