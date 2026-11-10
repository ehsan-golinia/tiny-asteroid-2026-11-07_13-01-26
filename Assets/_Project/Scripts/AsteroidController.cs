using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    #region Public Variables
    public float AsteroidSpeed = 1f;
    public float RotationSpeed = 20f;
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
        transform.position += Vector3.down * AsteroidSpeed * Time.deltaTime;
        transform.Rotate(Vector3.forward * RotationSpeed * Time.deltaTime);
    }
    #endregion
}
