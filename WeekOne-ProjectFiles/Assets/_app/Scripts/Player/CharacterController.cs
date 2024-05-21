using System;
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
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerJump();
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                MovementVector.x = 1;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                MovementVector.x = -1;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                MovementVector.z = 1;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                MovementVector.z = -1;
            }
            
            PlayerMovement();

        }

        private void PlayerJump()
        {
            rb.AddForce(JumpForce, ForceMode.Impulse);
        }

        private void PlayerMovement()
        {
            transform.Translate(new Vector3(MovementVector.x,MovementVector.y,MovementVector.z)*MovementSpeed * Time.deltaTime);
        }

    }
}