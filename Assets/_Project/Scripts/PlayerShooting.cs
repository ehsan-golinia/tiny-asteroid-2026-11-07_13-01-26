using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    #region Public Variables
    public GameObject BulletPrefab;
    public GameObject Gun;
    #endregion

    #region Private Variables
    #endregion

    #region Public Methods
    #endregion

    #region Private Methods
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(BulletPrefab, Gun.transform.position, Quaternion.identity);
        }
    }
    #endregion
}
