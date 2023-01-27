using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicLabel : MonoBehaviour
{
    private Camera cam;
    private LineRenderer lineRenderer;

    // Game objects between which the line is drawn
    [SerializeField] GameObject source;
    [SerializeField] GameObject target;

    // Width of the line
    [SerializeField] float linewidth = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        // Camera to which the label is facing all the time
        cam = Camera.main;

        // Make sure you have a Line Renderer component attached to your game object
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Make sure label faces the camera
        transform.LookAt(transform.position + cam.transform.rotation * Vector3.forward, cam.transform.rotation * Vector3.up);

        // If you have two game objects assigned as source and target then draw a line between them
        if (source != null && target != null)
        {
            Vector3[] pos = new Vector3[] { source.transform.position, target.transform.position };
            lineRenderer.SetPositions(pos);
            lineRenderer.startWidth = linewidth;
        }
    }
}
