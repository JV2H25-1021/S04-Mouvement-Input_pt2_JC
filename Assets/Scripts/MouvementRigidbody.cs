using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementRigidbody : MonoBehaviour
{
    private Rigidbody _rb;
    
    void Start()
    {
        // Prends une réference au Rigidbody attaché a cet objet.
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
         Vector3 deplacement = _rb.position + new Vector3(1f * Time.fixedDeltaTime, 0, 0);
         _rb.MovePosition(deplacement);

        // _rb.velocity = transform.TransformDirection(Vector3.forward);
    }
}
