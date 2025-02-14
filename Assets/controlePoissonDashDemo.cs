using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class controlePoissonDashDemo : MonoBehaviour
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
}
