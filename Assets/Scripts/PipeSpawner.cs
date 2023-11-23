using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _maxHeight = 0.45f;
    [SerializeField] private GameObject _pipe;

    private float _timer;


    private void Spawn()
    {
        Vector3 _pipeposition = transform.position + new Vector3(0,Random.Range(-_maxHeight,+_maxHeight),0);

        GameObject pipe = Instantiate(_pipe, _pipeposition, Quaternion.identity);

        Destroy(pipe, 10);
    }

    void Start() => Spawn();


    void Update()
    {
        if (_timer > _maxTime)
        {
            Spawn();
            _timer = 0;
        }

        _timer += Time.deltaTime;

        
    }
}
