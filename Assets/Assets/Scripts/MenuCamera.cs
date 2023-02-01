using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCamera : MonoBehaviour
{
    MenuControls controls;
    //Assign a GameObject in the Inspector to rotate around
    public GameObject target;
    public int amount;
    Vector2 rotate;

    private void Awake()
    {
        SetupController();
    }

    void Update()
    {
        // Spin the object around the target at 20 degrees/second.
        //transform.RotateAround(target.transform.position, Vector3.up, amount * Time.deltaTime);
        Rotate();
    }

    void SetupController()
    {
        controls = new MenuControls();
        controls.InMenu.RStick.performed += ctx => rotate = ctx.ReadValue<Vector2>();
    }

    void Rotate()
    {
        transform.RotateAround(target.transform.position, Vector3.up, (rotate.x * 50) * Time.deltaTime);
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
