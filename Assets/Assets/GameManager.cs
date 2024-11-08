using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> enemies = new List<GameObject>();
    private PlayerController playerController;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy").ToList();
    }

    void Update()
    {
        if(enemies.Count == 0) 
        {
            FindObjectOfType<PlayerController>().Win();
        }
    }
}
