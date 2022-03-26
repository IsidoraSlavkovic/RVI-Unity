using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> spawnedEnemies;
    public GameObject enemyPrefab;
    List<Vector3> spawnPoints;
    public int numberOfEnemies;

    
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        spawnedEnemies = new List<GameObject>();
        spawnPoints = new List<Vector3>();
        spawnPoints.Add(new Vector3(-60, 0, -30));
        spawnPoints.Add(new Vector3(-48, 0, -37));
        spawnPoints.Add(new Vector3(-38, 0, -37));
    }

    public GameObject SpawnEnemy() {
        int randomIndex = Random.Range(0, spawnPoints.Count - 1);
        return Instantiate(enemyPrefab, spawnPoints[randomIndex], enemyPrefab.transform.rotation);
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfEnemies; i++) {
            GameObject newEnemy = SpawnEnemy();
            newEnemy.GetComponent<Enemy>().player = GameObject.Find("TT_demo_police");
            spawnedEnemies.Add(newEnemy);            
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
