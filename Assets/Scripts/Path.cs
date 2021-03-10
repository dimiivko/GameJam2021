using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public Animator animator;
    Vector2 movement;
    Vector3 lastPoz=new Vector3(0f , 0f, 0f);
    // Array of waypoints to walk from one to the next one
    [SerializeField]
    private Transform[] waypoints;

    // Walk speed that can be set in Inspector
    [SerializeField]
    private float moveSpeed = 2f;
    private float moveSpeedPrev = 0.0f;
    private float moveSpeedCurr = 0.0f;
    private int waypointIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("go") == 1)
        {
            Move();
        }
        
    }

    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1)
        {

            movement = transform.position;
            if (waypoints[waypointIndex].transform.position!= lastPoz)
            {
                moveSpeedCurr = 0.0f;
            }
            moveSpeedCurr = (moveSpeedCurr + moveSpeed) / 2;
            transform.position = Vector2.MoveTowards(transform.position,
               waypoints[waypointIndex].transform.position,
               moveSpeedCurr * Time.deltaTime);
            movement.x = transform.position.x -movement.x ;
            movement.y = transform.position.y - movement.y;
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude*100);


        }
    }
}
