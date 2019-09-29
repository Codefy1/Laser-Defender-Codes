using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Wave Config")]
public class WaveConfig : ScriptableObject
{
    //config parameters

    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject pathPrefab;
    [SerializeField] float timeBetweenSpawns = 0.5f;
    [SerializeField] float spawnRandomFactor = 0.3f;
    [SerializeField] int numberOfEnemies = 5;
    [SerializeField] float moveSpeed = 2f;

    public GameObject GetEnemyPrefab() { return enemyPrefab; } /*returns the enemy prefab attached to the 
                                                                serialized variable enemyPrefab. */
    public List<Transform> GetWaypoints() //List of type transform.
    {
        var waveWaypoints = new List<Transform>();
        foreach (Transform child in pathPrefab.transform)
        {
            waveWaypoints.Add(child); 
        }
        return waveWaypoints;
    }

    public float GetTimeBetweenSpawns() { return timeBetweenSpawns; } /*returns the time after which 
                                                                       new enemy clone has to be spawned */

    public float GetSpawnRandomFactor() { return spawnRandomFactor; } /*randomly spawns waves */

    public int GetNumberOfEnemies() { return numberOfEnemies; } /* returns the number of enemy in an enemy wave.*/

    public float GetMoveSpeed() { return moveSpeed; } /* returns the movement speed of the enemy wave*/

}