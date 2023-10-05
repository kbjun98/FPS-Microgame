using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.FPS.Game;
using Unity.FPS.AI;
using Unity.FPS.Gameplay;

public class LootRandom : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> lootList;
    EnemyController m_enemyController;

    void Awake()
    {
    }

    void Start()
    {
        m_enemyController= GetComponent<EnemyController>();
        GameObject pickup = lootList[Random.Range(0, lootList.Count)];
        m_enemyController.LootPrefab = pickup;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
