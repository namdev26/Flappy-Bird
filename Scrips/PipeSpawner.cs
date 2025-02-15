using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : NamMonoBehaviour
{
    [SerializeField] private float _timer = 0f;
    [SerializeField] private GameObject _pipe;
    [SerializeField] private float _heightRange = 1f;
    [SerializeField] private float _maxTime = 2f;

    private void Start()
    {
        this.SpawnPipe();
    }    

    private void Update()
    {
        if (_timer >= _maxTime){
            this.SpawnPipe();
            _timer = 0f;
        }
        _timer += Time.deltaTime;
    }
    private void SpawnPipe(){
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));
        GameObject pipe = Instantiate(_pipe, spawnPos, Quaternion.identity);

        Destroy(pipe, 10f);
    }
}
