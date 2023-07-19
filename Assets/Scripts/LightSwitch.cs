using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    public Color lightColor;
    public InputActionReference action;

    private Color defaultLightColor = Color.white;
    private bool isLightNormal;

    void Start()
    {
        light = GetComponent<Light>();
        isLightNormal = true;

        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (isLightNormal)
            {
                light.color = lightColor;
                isLightNormal = false;
            } else
            {
                light.color = defaultLightColor;
                isLightNormal = true;
            }
        };
    }

    void Update()
    {
        
    }
}
