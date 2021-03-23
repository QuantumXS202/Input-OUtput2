using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Cube : MonoBehaviour
{
    public Material myMaterial;

    PlayerControls controls;
    
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

    }

    void Update()
    {
        
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

    void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    void OnDisable()
    {
        controls.Gameplay.Disable();
    }
}
