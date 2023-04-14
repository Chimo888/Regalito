using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

[RequireComponent(typeof(Camera))]
public class cameraZoom : MonoBehaviour
{
    public float transitionSpeed = 0.3f;
    private float desiredCameraSize;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
        desiredCameraSize = cam.orthographicSize;
    }

    void Update()
    {
        cam.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, desiredCameraSize, transitionSpeed);
    }

    public void ZoomCamera(float size)
    {
        desiredCameraSize = size;
    }
}