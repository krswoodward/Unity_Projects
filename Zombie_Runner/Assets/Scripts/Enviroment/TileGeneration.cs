using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGeneration : MonoBehaviour
{
    public GameObject[] tilePrefabs;

    private Transform playerTransform;
    private float spawnZ = 50.0f; //first spawn on z axis
    private float safeZone = 50; //safe distance before old tile deletion
    private float tileLength = 50.0f;//legnth of Prefab sections
    private int tilesOnScreen = 5;//initial tile to spawn at begging of scene
    private int lastPrefabIndex = 0;
   
    private List<GameObject> activeTiles = new List<GameObject>();


    private void Start()
    {

        playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;
       
        for (int i = 0; i < tilesOnScreen; i++)
        {
            SpawnTile();
        }
    }

    void Update()
    {
        if( playerTransform.position.z - safeZone > (spawnZ - tilesOnScreen * tileLength))
        {
            SpawnTile();
            DeleteTile();
        }
    }


    private void SpawnTile (int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate(tilePrefabs[RandomPefabIndex()]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
        activeTiles.Add (go);
;
    }
    private void DeleteTile()
    {

            Destroy(activeTiles[0]);
            activeTiles.RemoveAt(0);
  
    }

private int RandomPefabIndex()
    {
        if (tilePrefabs.Length <= 1)
            return 0;

        int randomIndex = lastPrefabIndex;
        while (randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, tilePrefabs.Length);
        }

        lastPrefabIndex = randomIndex;
        return randomIndex;
    }
}
