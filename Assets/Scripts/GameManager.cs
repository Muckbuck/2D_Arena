using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Manager
{
    public class GameManager : MonoBehaviour
    {

        PlayerManager newPlayer;
        CameraManager newCamera;

        void Start()
        {

            newPlayer = new PlayerManager();
            newCamera = new CameraManager();
            Dictionary<string, UnityEngine.KeyCode> movementScheme = new Dictionary<string, KeyCode>();

            movementScheme.Add("up", KeyCode.W);
            movementScheme.Add("down", KeyCode.S);
            movementScheme.Add("left", KeyCode.A);
            movementScheme.Add("right", KeyCode.D);

            newPlayer.SetupPlayer();
            newPlayer.SpawnPlayer(new Vector3(0f,0f));
            newPlayer.movementScheme = movementScheme;
            newPlayer.speed = 1;

            newCamera.SetupCamera();
            
            
        }

        void Update()
        {
            newPlayer.MovementHandler();
            Debug.Log(newPlayer.GetComponent<Transform>().position);
            newCamera.SetCameraToPlayerPosition(newPlayer.GetComponent<Transform>().position);

        }
    }

}
