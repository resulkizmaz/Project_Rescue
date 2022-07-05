using System.Collections;
using UnityEngine;
using TMPro;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] Transform enemyPrefab;
    [SerializeField] Transform spawnPoint;

    [SerializeField] TextMeshProUGUI waveCountText;
    
    [SerializeField] float timeBetweenWaves = 5f;

    float countDown = 2f;
    int waveIndex = 0;
    int waveCount = 0;

    private void Update()
    {
        if (waveCount<11)
        {
            if (countDown <= 0 && waveCount < 2)
            {
                spawnPoint.position = new Vector3(6, 0, -60);
                StartCoroutine(SpawnWave());
                countDown = timeBetweenWaves;
            }
            if (countDown <= 0 && waveCount < 4 && waveCount > 2)
            {
                spawnPoint.position = new Vector3(18, 0, -41);
                StartCoroutine(SpawnWave());
                countDown = timeBetweenWaves;
            }
            if (countDown <= 0 && waveCount < 7 && waveCount > 4)
            {
                spawnPoint.position = new Vector3(-6, 0, -15);
                StartCoroutine(SpawnWave());
                countDown = timeBetweenWaves;
            }
            if (countDown <= 0 && waveCount < 11 && waveCount > 7)
            {
                spawnPoint.position = new Vector3(-6, 0, 25);
                StartCoroutine(SpawnWave());
                countDown = timeBetweenWaves;
            }
        }
        
        countDown -= Time.deltaTime;
    }

    IEnumerator SpawnWave()
    {
        waveIndex++;
        timeBetweenWaves += 1f;

        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            waveCount += 1;
            waveCountText.text = waveCount.ToString();
            yield return new WaitForSeconds(0.5f);
        }
    }
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
