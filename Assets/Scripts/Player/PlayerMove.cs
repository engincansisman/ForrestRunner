using System;
using Environment;
using UnityEngine;

namespace Player
{
    public class PlayerMove : MonoBehaviour
    {
        private CharacterController controller;
        public float moveSpeed = 3;
        public float leftRightSpeed = 4;
        static public bool canMove = false;
        private float verticalVelocity;
        private float gravity = 14.0f;
        private float jumpForce = 10.0f;


        private void Start()
        {
            controller = GetComponent<CharacterController>();
        }


        // Update is called once per frame
        void Update()
        {
            
            transform.Translate(Vector3.forward * (Time.deltaTime * moveSpeed), Space.World);
            if (canMove == true)
            {
                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                {
                    if (gameObject.transform.position.x > LevelBoundry.leftSide)
                    {
                        transform.Translate(Vector3.left * (Time.deltaTime * leftRightSpeed));
                    }
                }

                if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                {
                    if (gameObject.transform.position.x < LevelBoundry.rightSide)
                    {
                        transform.Translate(Vector3.right * (Time.deltaTime * leftRightSpeed));
                    }
                }

                if (controller.isGrounded)
                {
                    verticalVelocity = gravity * Time.deltaTime;
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        verticalVelocity = jumpForce;
                    }
                }
                else
                {
                    verticalVelocity -= gravity * Time.deltaTime;
                }

                Vector3 moveVector= Vector3.zero;
                moveVector.y = verticalVelocity;
                controller.Move(moveVector * Time.deltaTime);

            }
        }

       

        

       
    }
}
