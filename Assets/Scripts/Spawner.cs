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


        RandomObjectSpawn("BlueHuman", 3, 5);
        RandomObjectSpawn("YellowHuman", 3, 5);
        RandomObjectSpawn("PurpleHuman", 3, 5);
        RandomObjectSpawn("PinkHuman", 3, 5);
        RandomObjectSpawn("GreenHuman", 3, 5);

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
            spawnPosition = new Vector3(Random.Range(-15.0f, 15.0f), Random.Range(-15, 15), 0);
        }
        while(Physics.OverlapSphereNonAlloc(spawnPosition, 0.5f, collisions) > 0);

        return spawnPosition;
    }


    private void RandomObjectSpawn(string Object, int min, int max)
    {
        letters = Random.Range(min, max);
        while (letters > 0)
        {
            var human = Instantiate(Resources.Load(Object), GetFreespawnPosition(), Quaternion.identity);
            letters--;
        }
    }
}