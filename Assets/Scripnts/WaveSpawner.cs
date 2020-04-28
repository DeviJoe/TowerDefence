using System.Collections;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

    public Transform enemyPrefab;
    public Transform spawnPoint;

    public static float TimeBetweenWaves = 5f;
    public static float Countdown = 2f;

    private int _waveNumber = 1;
    private void Update()
    {
        if (Countdown <= 1f)
        {
            StartCoroutine(SpawnWave());
            Countdown = TimeBetweenWaves;
        }

        Countdown -= Time.deltaTime;
    }

    IEnumerator SpawnWave()
    {
        for (int i = 0; i < _waveNumber; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);

        }
        _waveNumber++;
    }

    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
