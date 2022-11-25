using UnityEngine;
using System.Collections;
using TMPro;

public class WaveSpawner : MonoBehaviour
{
    public static int EnemiesAlive;
    public Transform spawnPoint;
    public TMP_Text WaveCountdownText;
    public float timeBetweenWaves = 5.5f;
    private float countdown = 2f;
    private int waveIndex = 0;
    public Wave[] waves;
    public GameMaster gameMaster;
    void Start()
    {
        EnemiesAlive = 0;
    }
    void Update()
    {
        //to wait for all enemies to be ended
        if(EnemiesAlive > 0)
        {
            return;
        }
        if (waveIndex >= waves.Length)
        {
            gameMaster.WinLevel();
            this.enabled = false;
        }
        if (countdown <= 0)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            //to wait for all enemies to be ended
            return;
        }
        countdown -= Time.deltaTime;
        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);
        WaveCountdownText.text = string.Format("{0:00.00}", countdown);
    }

    IEnumerator SpawnWave()
    {
        PlayerStats.Rounds++;
        Wave wave = waves[waveIndex];
        EnemiesAlive = wave.count;
        Debug.Log("Wave Incoming!");
        for(int i = 0; i < wave.count; i++)
        {
            SpawnEnemy(wave.enemy);
            yield return new WaitForSeconds(1f / wave.rate);
        }
        waveIndex++;
    }

    void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }
}
