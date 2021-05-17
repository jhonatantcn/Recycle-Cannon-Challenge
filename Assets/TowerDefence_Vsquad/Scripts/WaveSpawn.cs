using UnityEngine;
using System.Collections;

public class WaveSpawn : MonoBehaviour {

	public int WaveSize;
	public GameObject EnemyPrefab;
	public float EnemyInterval;
	public Transform spawnPoint;
	public float spawnMinX = -4;
	public float spawnMaxX = 4;
	public float startTime;
	public Transform[] WayPoints;
	int enemyCount=0;

	private Vector3 newSpawnPoint;

	void Start ()
    {
	 InvokeRepeating("SpawnEnemy",startTime,EnemyInterval);
	}

	void Update()
	{
		if(enemyCount == WaveSize)
		{
			CancelInvoke("SpawnEnemy");
		}
	}

	void SpawnEnemy()
	{
		enemyCount++;
		float x = Random.Range(spawnMinX, spawnMaxX);
		newSpawnPoint = new Vector3(x, spawnPoint.position.y, spawnPoint.position.z); // Random position to spawn Enemy

		GameObject enemy = GameObject.Instantiate(EnemyPrefab, newSpawnPoint, Quaternion.identity) as GameObject;
		enemy.GetComponent<Enemy>().waypoints = WayPoints;
      
    }
}
