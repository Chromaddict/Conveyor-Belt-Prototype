using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] cubePrefab;
    [SerializeField] float spawnDelay = 3;
    [SerializeField] int spawnAmount = 30;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnCube");
    }

    public IEnumerator SpawnCube()
    {
        while(++count <= spawnAmount)
        {
            Instantiate(cubePrefab[Random.Range(0, cubePrefab.Length)], transform.position, Quaternion.identity, gameObject.transform);
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
