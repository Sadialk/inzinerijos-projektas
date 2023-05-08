using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawn : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform SpawnPoint;
    public float timeBetweenWaves = 5f;
    public float countdown = 2f;
    private int waveIndex = 1;
    public TMP_Text CurrentWaveText;
    public int WAVE_AMOUNT = 2;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (WAVE_AMOUNT <= 0)
        {
            // game ends;
        }
        if (countdown <= 0f && WAVE_AMOUNT > 0)
        {
            Debug.Log("UPD:ATE");
            CurrentWaveText.text = waveIndex.ToString();
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            WAVE_AMOUNT--;
        }
        countdown -= Time.deltaTime;
    }
    IEnumerator SpawnWave()
    {
        Debug.Log("Spawn wave!");

        for (int i = 0; i < waveIndex; i++)
        {

            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
        waveIndex++;
    }
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, SpawnPoint.position, SpawnPoint.rotation);
    }
}
