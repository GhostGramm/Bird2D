using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] float maxY;
    [SerializeField] float spawnInterval;
    public GameObject[] Birds;
    void Start()
    {
        StartSpawningBirds();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InstantiateBirds()
    {
        int randomBirdIndex = Random.Range(0, Birds.Length);
        float randomYpos = Random.Range(-maxY, maxY);

        Vector3 BirdPosition = new Vector3(transform.position.x, randomYpos, transform.position.z);
        Instantiate(Birds[randomBirdIndex], BirdPosition, transform.rotation);
    }

    IEnumerator SpawnBirds()
    {
        yield return new WaitForSeconds(1f);

        while (true)
        {
            InstantiateBirds();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    public void StartSpawningBirds()
    {
        StartCoroutine(SpawnBirds());
    }

    public void StopSpawningBirds()
    {
        StopCoroutine(SpawnBirds());
    }
}
