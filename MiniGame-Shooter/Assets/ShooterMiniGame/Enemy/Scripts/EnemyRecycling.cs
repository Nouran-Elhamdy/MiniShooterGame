using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRecycling : MonoBehaviour
{
    List<GameObject> deadEnemies;
    [SerializeField] float timeToSpawn;
    private void Start()
    {
        deadEnemies = new List<GameObject>();
    }
    private void Update()
    {
        for (int i = 0; i < this.gameObject.transform.childCount; i++)
        {
            if(!this.gameObject.transform.GetChild(i).gameObject.activeSelf)
            {
                deadEnemies.Add(this.gameObject.transform.GetChild(i).gameObject);
                Invoke("Respawn", timeToSpawn);
            }
        }
    }

    public void Respawn()
    {
        for (int i = 0; i < deadEnemies.Count; i++)
        {
            deadEnemies[i].SetActive(true);
            deadEnemies.Remove(deadEnemies[i]);
        }
     
    }
}
