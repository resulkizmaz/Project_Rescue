using System.Collections;
using UnityEngine;
using TMPro;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] Transform enemyPrefab;
    [SerializeField] Transform enemyPrefab1;
    [SerializeField] Transform spawnPoint;
    [SerializeField] Transform spawnPoint1;

    [HideInInspector] public int waveCount = 0;

    public TextMeshProUGUI waveCountText;

    [SerializeField] float timeBetween;
    float timeBetweenWaves = 3f;
    float countDown = 2f;
    int waveIndex = 0;
    

    private void Update()
    {
        if (waveCount<11)
        {
            if (countDown <= 0)
            {
                if (waveCount < 2)
                {
                    spawnPoint.position = new Vector3(6, 0, -60);
                    spawnPoint1.position = new Vector3(18, 0, -41);
                    StartCoroutine(SpawnWave());
                    countDown = timeBetweenWaves;
                }
                else if (waveCount < 4)
                {
                    spawnPoint.position = new Vector3(18, 0, -41);
                    spawnPoint1.position = new Vector3(-6, 0, -15);
                    StartCoroutine(SpawnWave());
                    countDown = timeBetweenWaves;
                }
                else if (waveCount < 7)
                {
                    spawnPoint.position = new Vector3(-6, 0, -15);
                    spawnPoint1.position = new Vector3(-6, 0, 25);
                    StartCoroutine(SpawnWave());
                    countDown = timeBetweenWaves;
                }
                else if (waveCount < 11)
                {
                    spawnPoint.position = new Vector3(-6, 0, 25);
                    StartCoroutine(SpawnWave());
                    countDown = timeBetweenWaves;
                }
            }
        }
        
        countDown -= Time.deltaTime;
    }

    IEnumerator SpawnWave()
    {
        waveIndex++;
        timeBetweenWaves += timeBetween;

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
        Instantiate(enemyPrefab1, spawnPoint1.position, spawnPoint.rotation);
    }
}
