using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] float maxY;
    public GameObject[] Birds;
    void Start()
    {
        SpawnBirds();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnBirds()
    {
        int randomBirdIndex = Random.Range(0, Birds.Length);
        float randomYpos = Random.Range(-maxY, maxY);

        Vector3 BirdPosition = new Vector3(transform.position.x, randomYpos, transform.position.z);
        Instantiate(Birds[randomBirdIndex], BirdPosition, transform.rotation);
    }
}
