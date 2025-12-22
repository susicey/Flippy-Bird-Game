using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PipleScripts : MonoBehaviour
{


    [SerializeField] private GameObject piplePrefab;

    [SerializeField] private float pipleSpawnTime = 1.5f;
    [SerializeField] private float height = 0.5f;
    private void Start()
    {
        StartCoroutine(SpawnPiple());

    }

    private void Update()
    {

    }
    private IEnumerator SpawnPiple()
    {
        while (true)
        {
            Instantiate(piplePrefab, new Vector3(3f, Random.Range(-height, height), 0), Quaternion.identity);

            yield return new WaitForSeconds(pipleSpawnTime);
            print("WaitAndPrint");
        }
    }
}

