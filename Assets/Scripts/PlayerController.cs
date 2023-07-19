using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public InputActionReference iaQuit;
    public InputActionReference iaGoOutside;
    public InputActionReference iaGoInside;
    public Vector3 roomPosition;
    public Vector3 outsidePosition;

    void Start()
    {
        // Quit
        iaQuit.action.Enable();
        iaQuit.action.performed += (ctx) =>
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        };

        // Go Outside
        iaGoOutside.action.Enable();
        iaGoOutside.action.performed += (ctx) =>
        {
            transform.SetPositionAndRotation(outsidePosition, Quaternion.identity);
        };

        // Go Inside
        iaGoInside.action.Enable();
        iaGoInside.action.performed += (ctx) =>
        {
            transform.SetPositionAndRotation(roomPosition, Quaternion.identity);
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
