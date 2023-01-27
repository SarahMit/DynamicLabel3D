using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 200.0f;

    private Vector3 startRotation;

    // Start is called before the first frame update
    void Start()
    {
        // Original rotation of objects
        startRotation = transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        // Rotation around y-axis
        if (Input.GetMouseButton(0))
        {
            startRotation.y -= Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(startRotation.x, startRotation.y, startRotation.z);
        }
    }
}
