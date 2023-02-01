using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightsaberSelect : MonoBehaviour
{
    MenuControls controls;

    //public GameObject m_EmissiveObject;
    public Transform rightHandPos;
    public Transform leftHandPos;
    public GameObject lightsaberObj;
    public Color lightsaber1Color;
    public Color lightsaber2Color;
    public bool isOn = false;
    GameObject lightsaber1;
    GameObject lightsaber2;
    GameObject lightsaber1Saber;
    GameObject lightsaber2Saber;

    void Awake()
    {
        CreateLightsaber();
        SetupController();
    }

    private void Update()
    {
        //LightsaberMode();
    }

    void CreateLightsaber()
    {
        float emissiveIntensity = 312;

        lightsaber1 = Instantiate(lightsaberObj, rightHandPos);
        lightsaber2 = Instantiate(lightsaberObj, leftHandPos);
        lightsaber1.GetComponentInChildren<Light>().color = lightsaber1Color;
        lightsaber1.GetComponentInChildren<ParticleSystemRenderer>().material.SetColor("_EmissiveColor", lightsaber1Color * emissiveIntensity);
        lightsaber2.GetComponentInChildren<Light>().color = lightsaber2Color;
        lightsaber2.GetComponentInChildren<ParticleSystemRenderer>().material.SetColor("_EmissiveColor", lightsaber2Color * emissiveIntensity);
        lightsaber1Saber = lightsaber1.GetComponentInChildren<ParticleSystemRenderer>().gameObject;
        lightsaber2Saber = lightsaber2.GetComponentInChildren<ParticleSystemRenderer>().gameObject;
        lightsaber2Saber.SetActive(false);
        lightsaber1Saber.SetActive(false);
    }

    void LightsaberMode()
    {
        isOn = !isOn;
        if(isOn == true)
        {
            lightsaber2Saber.SetActive(isOn);
            lightsaber1Saber.SetActive(isOn);

        }
        if (isOn == false)
        {
            lightsaber2Saber.SetActive(isOn);
            lightsaber1Saber.SetActive(isOn);
        }
    }

    void SetupController()
    {
        controls = new MenuControls();
        controls.InMenu.West.performed += ctx => LightsaberMode();
    }

    private void OnEnable()
    {
        controls.InMenu.Enable();
    }

    private void OnDisable()
    {
        controls.InMenu.Disable();
    }
}
