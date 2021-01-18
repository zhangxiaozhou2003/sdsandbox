using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MapReader : MonoBehaviour
{
    [SerializeField]
    private Texture2D map;

    [SerializeField]
    private GameObject wallObject;
    [SerializeField]
    private GameObject groundObject;

    List<GameObject> objectList = new List<GameObject>();
    
    // Start is called before the first frame update
    void Start()
    {
        Color[] pix = map.GetPixels();

        float worldX = map.width*0.05f;
        float worldZ = map.height*0.05f;

        Vector3[] spawnPositions = new Vector3[pix.Length];
        Vector3 startingSpawnPosition = new Vector3(Mathf.Round(worldX/2),0,-Mathf.Round(worldZ/2));
        Vector3 currentSpawnPosition = startingSpawnPosition;

        int counter = 0;

        for (int x = 0; x<map.height; x++)
        {
            for (int z = 0; z<map.width; z++)
            {
                spawnPositions[counter] = currentSpawnPosition;
                counter++;
                currentSpawnPosition.z = currentSpawnPosition.z+0.05f;
            }
            currentSpawnPosition.z = startingSpawnPosition.z;
            currentSpawnPosition.x = currentSpawnPosition.x-0.05f;
        }

        counter = 0;

        for (int i=0; i<spawnPositions.Length; i=i+1)
        {
            Color c = pix[i];
            if (c.Equals(Color.black))
            {
                Instantiate(wallObject, spawnPositions[i], Quaternion.identity);
            }

        }
        // foreach (Vector3 pos in spawnPositions)
        // {
        //     Color c = pix[counter];

        //     // if (c.Equals(Color.white))
        //     // {
        //     //     Instantiate(groundObject, pos, Quaternion.identity);
        //     // }
        //     if (c.Equals(Color.black))
        //     {
        //         Instantiate(wallObject, pos, Quaternion.identity);
        //     }

        //     counter++;
        // }

        // for(int i = 0; i< objectList.Count; i++){
        //     PrefabUtility.SaveAsPrefabAsset(objectList[i], "Assets/Prefabs/levine.prefab");
        // }


    

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
