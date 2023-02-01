using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public LightsaberSelect lightsaberSelect;
    public Color lightsaber1Color;
    public Color lightsaber2Color;

    private void Awake()
    {
        lightsaberSelect.lightsaber1Color = lightsaber1Color;
        lightsaberSelect.lightsaber2Color = lightsaber2Color;
    }
}
