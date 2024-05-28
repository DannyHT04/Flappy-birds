using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _heightRange = .45f;
    [SerializeField] private GameObject _pipe;

    private float _timer;
    private void Start()
    {
        SpawnPipe();
    }

    private void Update()
    {
        if(_timer > _maxTime)
        {
            SpawnPipe();
            _timer = 0;
        }
        _timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        // Calculate the spawn position by adding a random vertical offset to the current position
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));

        // Instantiate a new pipe GameObject at the calculated position with no rotation
        GameObject pipe = Instantiate(_pipe, spawnPos, Quaternion.identity);
        
        // Schedule the newly created pipe to be destroyed after 10 seconds
        Destroy(pipe, 10f);
    }
}
