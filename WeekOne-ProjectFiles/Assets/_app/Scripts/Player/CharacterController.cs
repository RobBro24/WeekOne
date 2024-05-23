using System;
using _app.Scripts.Managers;
using UnityEngine;

namespace _app.Scripts.Player
{
    public class CharacterController : MonoBehaviour
    {
        [Header("Movement Variables")] 
        public float MovementSpeed;

        public Vector3 MovementVector;
        public Vector3 JumpForce;
        public bool Crouching;

        [Header("Player Components")]
        public Rigidbody rb;

        public Camera playercamera;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        public void Update()
        {
            MovementVector.x = Input.GetAxis("Horizontal");
            MovementVector.y = Input.GetAxis("Vertical");
            
            PlayerMovement(MovementVector);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameManager.Instance.playerScore++;
            }
            else
            {
                Debug.Log(message:"Game Manager is missing!");
            }

        }

        private void PlayerJump()
        {
            rb.AddForce(JumpForce, ForceMode.Impulse);
        }

        private void PlayerMovement(Vector2 movement)
        {
            transform.Translate(new Vector3(movement.y,0,movement.x)*(MovementSpeed * Time.deltaTime));
        }

    }
}