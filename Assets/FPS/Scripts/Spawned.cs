using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawned : MonoBehaviour
{
    private SpawnManager spawnManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setSpawner(SpawnManager spawnManger)
    {
        this.spawnManager = spawnManger;
    }

    public void OnDestroy()
    {
        
    }
}
