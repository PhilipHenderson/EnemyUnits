using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Enemy Properties")]
    public GameObject[] enemyPrefabs;
    public float spawnInterval = 3f;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            int randomIndex = Random.Range(0, enemyPrefabs.Length);
            GameObject selectedEnemy = enemyPrefabs[randomIndex];

            Instantiate(selectedEnemy, transform.position, Quaternion.identity);

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}