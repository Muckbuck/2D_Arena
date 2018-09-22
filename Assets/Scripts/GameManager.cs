using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Manager
{
    public class GameManager : MonoBehaviour
    {

        PlayerManager newPlayer = new PlayerManager();
        // Use this for initialization
        void Start()
        {
            Dictionary<string, UnityEngine.KeyCode> movementScheme = new Dictionary<string, KeyCode>();
            movementScheme.Add("up", KeyCode.W);
            movementScheme.Add("down", KeyCode.S);
            movementScheme.Add("left", KeyCode.A);
            movementScheme.Add("right", KeyCode.D);

            newPlayer.SetupPlayer();
            newPlayer.SpawnPlayer(new Vector3(0f,0f));
            newPlayer.movementScheme = movementScheme;
            newPlayer.speed = 1;
            
        }

        // Update is called once per frame
        void Update()
        {
            newPlayer.MovementHandler();
        }
    }

}
