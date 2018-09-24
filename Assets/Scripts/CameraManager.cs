using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Manager
{
    public class CameraManager : MonoBehaviour
    {

        GameObject cameraObject;    
        Transform cameraTransform;
        Vector2 heroPosition;
        // Use this for initialization

        public void SetupCamera()
        {
            cameraObject = new GameObject();
            cameraObject.AddComponent<Camera>();
            cameraObject.GetComponent<Camera>().nearClipPlane = -1f;
            cameraObject.GetComponent<Camera>().nearClipPlane = 100;
        }

        public void SetCameraToPlayerPosition(Vector3 playerPosition)
        {
            cameraTransform = cameraObject.GetComponent<Transform>();
            cameraTransform.position = cameraObject.GetComponent<Transform>().position;
        }

    }
}

