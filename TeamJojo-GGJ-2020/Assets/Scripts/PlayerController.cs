using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        CharacterController characterController;

        public float speed = 6.0f;
        public float jumpSpeed = 8.0f;
        public float gravity = 20.0f;

        public JoystickId joystickId = JoystickId.J1;

        private Vector3 moveDirection = Vector3.zero;

        private CharacterInputMaping input;

        // Start is called before the first frame update
        void Start()
        {
            characterController = GetComponent<CharacterController>();
            input = new CharacterInputMaping(joystickId);
        }

        void Update()
        {
            if (characterController.isGrounded)
            {
                // We are grounded, so recalculate
                // move direction directly from axes

                moveDirection = input.Movement * speed;

                if (input.Jump)
                {
                    Debug.Log(joystickId + " Jump");
                    moveDirection.y = jumpSpeed;
                }
            }

            // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
            // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
            // as an acceleration (ms^-2)
            moveDirection.y -= gravity * Time.deltaTime;

            // Move the controller
            characterController.Move(moveDirection * Time.deltaTime);

            if (input.Action1) Action1();
            if (input.Action2) Action2();
            if (input.Action3) Action3();
        }

        private void Action1()
        {
            Debug.Log(joystickId + " Action 1");
        }

        private void Action2()
        {
            Debug.Log(joystickId + " Action 2");
        }

        private void Action3()
        {
            Debug.Log(joystickId + " Action 3");
        }
    }
}