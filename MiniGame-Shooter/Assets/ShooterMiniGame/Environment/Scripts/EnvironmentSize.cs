using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSize : MonoBehaviour
{
    [SerializeField] int rows;
    [SerializeField] int columns;
    [SerializeField] int tileSpacing;
    [SerializeField] GameObject tilePrefab;
    private void Start()
    {
        GenerateEnvironment();
    }

    public void GenerateEnvironment()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                GameObject tiles = Instantiate(tilePrefab, transform);
                float x = col * tileSpacing;
                float z = row * -tileSpacing;

                tiles.transform.position = new Vector3(x, 0, z); 
            }
        }
    }
}
