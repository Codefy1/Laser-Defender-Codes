using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    WaveConfig waveConfig;
    List<Transform> waypoints;
    int waypointIndex = 0;  

    // Use this for initialization
    void Start()
    {
        waypoints = waveConfig.GetWaypoints();
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void SetWaveConfig(WaveConfig waveConfig)
    {
        this.waveConfig = waveConfig;
    }
    private void Move()
    {
        if (waypointIndex <= waypoints.Count - 1) //count is used because it is a list.
        {
            var targetPosition = waypoints[waypointIndex].transform.position;  //Current waypoint position of enemy.
            var movementThisFrame = waveConfig.GetMoveSpeed() * Time.deltaTime; //movement speed of enemy from one waypoint to another.
            transform.position = Vector2.MoveTowards
                (transform.position, targetPosition, movementThisFrame); //a method to move from one waypoint to other.
            if (transform.position == targetPosition)
            {
                waypointIndex++; 
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}