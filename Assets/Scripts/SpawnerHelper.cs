using System.Collections;
using UnityEngine;

public class SpawnerHelper : MonoBehaviour
{

    [SerializeField] private Spawner spawner;
    [SerializeField] private int enemiesInWave = 10;
    [SerializeField] private float timeBetweenWaves = 20;
    [SerializeField] private int wavesCount = 3;
    [SerializeField] private Player player;
    private void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    public IEnumerator SpawnWaves()
    {
        for (int j = 0; j < wavesCount; j++)
        {
            Debug.Log("Started spawning wave");
            for (int i = 0; i < enemiesInWave; i++)
            {
                spawner.Spawn();
                yield return new WaitForSeconds(1);
            }
            yield return new WaitForSeconds(timeBetweenWaves);
            if (j == 3)
            {
                player.LevelUp();
            }
            else if (j == 7)
            {
                player.LevelUp();
            }
        }

    }
}

