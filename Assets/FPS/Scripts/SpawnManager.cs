using System.Collections;
using System.Collections.Generic;
using Unity.FPS.AI;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject spawnEnemy;
    public int maxSpawnEnemy;
    private int currentSpawnEnemyCount = 0;
    public float spawnDelay;
    public PatrolPath patrolPath;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawning());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawning()
    {
        yield return new WaitForSeconds(spawnDelay);
        if(currentSpawnEnemyCount<maxSpawnEnemy)
        {
            GameObject spawnedEnemy = Instantiate(spawnEnemy, spawnPoint);
            Spawned spawned = spawnedEnemy.AddComponent<Spawned>();
            spawned.setSpawner(this);
            patrolPath.EnemiesToAssign.Add(spawnedEnemy.GetComponent<EnemyController>());
            currentSpawnEnemyCount++;
        }
        StartCoroutine(spawning());
    }

    public void productDestroyed()
    {
        currentSpawnEnemyCount--;
    }
}
