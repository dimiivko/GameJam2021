using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathRight : MonoBehaviour
{
    public Animator animator;
    Vector2 movement;
    // Array of waypoints to walk from one to the next one
    [SerializeField]
    private Transform[] waypoints;

    // Walk speed that can be set in Inspector
    [SerializeField]
    private float moveSpeed = 5f;
    private int waypointIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        // If Enemy didn't reach last waypoint it can move
        // If enemy reached last waypoint then it stops
        if (waypointIndex <= waypoints.Length - 1)
        {

            // Move Enemy from current waypoint to the next one
            // using MoveTowards method
            movement = transform.position;
            transform.position = Vector2.MoveTowards(transform.position,
               new Vector2( -waypoints[waypointIndex].transform.position.x, waypoints[waypointIndex].transform.position.y),
               moveSpeed * Time.deltaTime);
            movement.x = transform.position.x -movement.x ;
            movement.y = transform.position.y - movement.y;
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude*100);
            // If Enemy reaches position of waypoint he walked towards
            // then waypointIndex is increased by 1
            // and Enemy starts to walk to the next waypoint

        }
    }
}
