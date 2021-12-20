﻿using System.Collections;
using UnityEngine;

// This script controls the parent game object that groups several Aline enemies as its children
public class EnemyController : MonoBehaviour
{
    // An array of the enemy GameObjects
    public GameObject[] enemies;

    // The min and max limits on the horizontal X-axis where this game object can move within
    public float minPosX;
    public float maxPosX;

    // The min and max limits on the Y-axis
    public float minPosY;
    public float maxPosY;

    // How far to move per one step
    public float moveDistanceX;
    public float moveDistanceY;

    // How much time interval between one motion and the next
    public float timeStep;

    // A boolean to check which direction the game object is currently moving
    private bool isMovingRight = true;


    // Use this for initialization
    void Start()
    {
        /* Call the function named in the first argument repeatedly
         * Second argument is how long the delay before the first time to call
         * Third argument is how the interval between every time it's called
         */ 
        InvokeRepeating("MoveEnemies", timeStep, timeStep);
    }

    // Moves the game object this script is on. And since this game object has the enemies as children,
    // they will also be moved with it by the same amount of distance
    void MoveEnemies()
    {
        // If the motion direction is Right, keep moving it in that direction. Else, move it in the opposite direction (left)
        if (isMovingRight)
        {
            // Get the current position of the game object on the horizontal X-axis
            float currentPositionX = gameObject.transform.position.x;
            
            // Calculate the new position the game object is expected to move to
            float newPositionX = currentPositionX + moveDistanceX;

            // The current position of the game object along the vertical Y-axis. We don't want to move the object vertically,
            // so we keep the value as is
            float currentPositionY = gameObject.transform.position.y;

            //To move the enemy on the y-axis
            float newPositionY = currentPositionY - moveDistanceY;

            // Combine the X and Y values of the new position together in a new Vector2 variable
            Vector2 newPosition = new Vector2(newPositionX, newPositionY);

            /*  Apply the new calculated position to the object's transform to actually make it move on screen
             *  The "position" property in transform is either a Vector2 (2d) or Vector3 (3d) data type, so we need to assign the values
             *  as one of those data types. Hence why newPosition is Vector2 data type
             */
            gameObject.transform.position = newPosition;
            
            // if the new position of the game object after moving is greater than or equals the max X limit, then reverse direction
            if (gameObject.transform.position.x >= maxPosX)
            {
                isMovingRight = false;
            }
        } 
        else
        {
            // The below is just like the above code, but inverted to accomodate for movement in the opposite (left) direction

            float currentPositionX = gameObject.transform.position.x;
            float currentPositionY = gameObject.transform.position.y;

            // The new position is calculated by subtracting the moveDistance, since going left means going in decreasing X values
            float newPositionX = currentPositionX - moveDistanceX;

            //The new position on y-axis
            float newPositionY = currentPositionY - moveDistanceY;

            
            Vector2 newPosition = new Vector2(newPositionX, newPositionY);

            gameObject.transform.position = newPosition;

            // Note that the check is with less than or equal, as the position X decreases as we go further left
            if (gameObject.transform.position.x <= minPosX)
            {
                isMovingRight = true;
            }
        }
    }
}