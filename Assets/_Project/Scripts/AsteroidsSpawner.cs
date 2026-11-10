using System.Collections;
using UnityEngine;

public class AsteroidsSpawner : MonoBehaviour
{
    #region Public Variables
    public GameObject AsteroidPrefab;
    public float MinTimeToSpawn = 2f;
    public float MaxTimeToSpawn = 6f;
    public float MinXAxisLimit = -6.6f;
    public float MaxXAxisLimit = 6.6f;
    #endregion

    #region Private Variables
    #endregion

    #region Public Methods
    #endregion

    #region Private Methods
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(Random.Range(MinTimeToSpawn, MaxTimeToSpawn));
        Vector3 pos = transform.position;
        pos.x = Random.Range(MinXAxisLimit, MaxXAxisLimit);
        Instantiate(AsteroidPrefab, pos, Quaternion.identity);
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    private void Update()
    {

    }
    #endregion
}
