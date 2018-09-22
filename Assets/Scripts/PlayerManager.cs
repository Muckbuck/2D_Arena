using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Manager
{
    public class PlayerManager : MonoBehaviour
    {


        public float speed;
        public Sprite heroSprite;
        public Dictionary<string, UnityEngine.KeyCode> movementScheme;
        Rigidbody2D rigidBody;
        GameObject playerObject;
        Transform trans;



        public void SpawnPlayer(Vector3 position)
        {
            this.playerObject.GetComponent<Transform>().position = position;
        }

        public void SetupPlayer()
        {
            playerObject = new GameObject();

            BoxCollider2D playerBoxCollider = playerObject.AddComponent<BoxCollider2D>();
            Rigidbody2D playerRigidBody = playerObject.AddComponent<Rigidbody2D>();
            SpriteRenderer playerSpriteRenderer = playerObject.AddComponent<SpriteRenderer>();
            Sprite playerSprite = Resources.Load<Sprite>("Sprites/Hero");

            
            playerRigidBody.gravityScale = 0;
            playerSpriteRenderer.sprite = playerSprite;
        }

        public void MovementHandler(float sleepLimit = 0f, float wakeLimit = 0.0f)
        {

            Vector2 forceUp = new Vector2(0f, 1f * speed);
            Vector2 forceDown = new Vector2(0f, -1f * speed);
            Vector2 forceLeft = new Vector2(-1f * speed, 0f);
            Vector2 forceRight = new Vector2(1f * speed, 0f);

            //If either W,A,S or D is pressed
            if (Input.GetKey(movementScheme["up"]))
            {
                //trans.Translate(forceUp * Time.deltaTime);
                playerObject.GetComponent<Transform>().Translate(forceUp * Time.deltaTime);
            }
            else if (Input.GetKey(movementScheme["down"]))
            {
                playerObject.GetComponent<Transform>().Translate(forceDown * Time.deltaTime);
            }
            else if (Input.GetKey(movementScheme["left"]))
            {
                playerObject.GetComponent<Transform>().Translate(forceLeft * Time.deltaTime);
            }
            else if (Input.GetKey(movementScheme["right"]))
            {
                playerObject.GetComponent<Transform>().Translate(forceRight * Time.deltaTime);
            }

            
        }

     

      
    }
}