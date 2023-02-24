using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randm : MonoBehaviour {
     float waitTime = 0.3f;
    float cubeSpawnTotal = 999;
    public List<GameObject> cubePrefabList;
        public GameObject panel;
        private GameObject lastspawn;


    void Start()
    {
        StartCoroutine(SpawnCube());
        lastspawn = cubePrefabList[1];
    }


    IEnumerator SpawnCube()
    {
        for (int i = 0; i < cubeSpawnTotal; i++)
        {   if(lastspawn == cubePrefabList[4]){
            GameObject prefabToSpawn = cubePrefabList[Random.Range(0, cubePrefabList.Count)];
                        lastspawn = prefabToSpawn;}else{
            GameObject prefabToSpawn = cubePrefabList[Random.Range(0, cubePrefabList.Count)];
            //Vector3 spawnPosition = Camera.main.ScreenToViewportPoint(new Vector3(Random.Range(0,Screen.width),0,Random.Range(0,Screen.height)));  //Random.Range(xPosMinLimit, xPosMaxLimit);
            lastspawn = prefabToSpawn;
            float yPos = Random.Range(-300, 300);
            Vector3 spawnPosition = new Vector3(800, yPos, 0f);
            GameObject spwanObj = Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity) as GameObject;
                        spwanObj.transform.SetParent(panel.transform);
            spwanObj.transform.localPosition = spawnPosition;
            yield return new WaitForSeconds(waitTime);
        }}
    }
}