using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    private IEnumerator spawn;
    private int letters;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("first Check");
        for (letters = Random.Range(3, 10); letters == 0; letters--)
        {
            Debug.Log("for check");
            var human = Instantiate(GameObject.Find("BlueHuman"), GetFreespawnPosition(), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }





    Vector3 GetFreespawnPosition()
    {
        Vector3 spawnPosition;
        Collider[] collisions = new Collider[1];
        do
        {
            spawnPosition = new Vector3(Random.Range(-2.0f, 4.0f), Random.Range(-3, 7), 0);
        }
        while(Physics.OverlapSphereNonAlloc(spawnPosition, 0.5f, collisions) > 0);

        return spawnPosition;
    }


}