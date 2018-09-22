using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Manager
{
    public class CameraManager : MonoBehaviour
    {

        GameObject[] hero;
        Transform cameraTransform;
        Vector2 heroPosition;
        // Use this for initialization
        void Start()
        {
            //hero = GameObject.FindGameObjectsWithTag("Hero");
            //cameraTransform = GetComponent<Transform>();

        }

        // Update is called once per frame
        void Update()
        {

            //cameraTransform.position = hero[0].GetComponent<Transform>().position;
        }
    }
}

