using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    [Header("Spawn Enemigos")]

    [Tooltip("Prefabs de Enemigos")]

    [SerializeField] private GameObject[] _enemiesPrefab;

    [Tooltip("Numero de enemigos que van a Spawnear")]

    [SerializeField] private int _enemiesToSpawn;
    [SerializeField] private Transform[] _spawnPoint;
    private BoxCollider2D _collider;
    private int _enemyIndex;
    

    private void Awake()
    {
        _collider = GetComponent<BoxCollider2D>();
    }

  

    void Update()
    {
        if(_enemiesToSpawn <= 0)
        {
            CancelInvoke();
        }
    }
    IEnumerator SpawnEnemy()
    {
        for(int i = 0; 1 < _enemiesToSpawn; i++)
        {
            _enemyIndex = Random.Range(0, _enemiesPrefab.Length);

        foreach(Transform spawn in _spawnPoint)
        {
            Instantiate(_enemiesPrefab[_enemyIndex], spawn.position, spawn.rotation);
            _enemiesToSpawn--;
            yield return new WaitForSeconds(1);
        }

        yield return new WaitForSeconds(1);
        }
        
       
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
            _collider.enabled = false;
            InvokeRepeating("SpawnEnemy", 0, 2);
            StartCoroutine(SpawnEnemy());
        }
    }
   
}
