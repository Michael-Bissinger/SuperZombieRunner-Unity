using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{

    public GameObject[] prefabs; // contains all prefabs, that the spawner can make
    public float delay = 2.0f;
    public bool active = true;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyGenerator());

    }

    IEnumerator EnemyGenerator()
    {

        yield return new WaitForSeconds(delay);

        if (active)
        {
            var newTransform = tranform;

            Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Transform.position, Quaternion.identity);

        }
        StartCoroutine(EnemyGenerator());

    }

}
