using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [Header ("🐱 Cat")]
    [SerializeField] private Transform _cat;
    [Header ("🌏 Spawne")]
    [SerializeField] private PlatformSpawner _spawner;
    
    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        if (_cat.GetComponent<Player>().IsMove) setSpawn();
    }
    public void setSpawn()
    {
        _spawner.isSpawn = true;
    }
}
