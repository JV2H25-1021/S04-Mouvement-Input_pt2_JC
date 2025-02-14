using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class exercise : MonoBehaviour
{
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void OnDash()
    {
        print("DASH!");
        _rb.AddRelativeForce(0, 0, 2f, ForceMode.VelocityChange);
    }
    float angle = 0f;

    void OnTourner(InputValue valeur)
    {
        angle = valeur.Get<float>();
    }

    private void FixedUpdate()
    {
        _rb.AddRelativeTorque(0, angle, 0, ForceMode.VelocityChange);
    }
}
