using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    [Header("Board Info")]
    [SerializeField]
    private int boardWidth;
    [SerializeField]
    private int boardHeight;

    [SerializeField]
    private GameObject tilePrefab;
    [SerializeField]
    private Transform parentTransform;

    private int balanceSize = 1;
    private float spacing = 0.1f;

    // temp
    [SerializeField]
    private GameObject characterPrefab;



    private void Awake()
    {
        for (int y = 0; y < boardHeight; y++)
        {
            for (int x = 0; x < boardWidth; x++)
            {
                GameObject clone = Instantiate(tilePrefab, new Vector3((x + spacing * x) * balanceSize, 0, (y + spacing * y) * balanceSize), Quaternion.identity, parentTransform);
                
                if (x == 0)
                {
                    GameObject TempCharacter = Instantiate(characterPrefab, new Vector3((x + spacing * x) * balanceSize, 0, (y + spacing * y) * balanceSize), Quaternion.identity);
                }
            }
        }
    }
}
