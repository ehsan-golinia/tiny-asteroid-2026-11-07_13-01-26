using UnityEngine;

public class BulletController : MonoBehaviour
{
    #region Public Variables
    public float BulletSpeed = 10f;
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
        transform.Translate(Vector3.up * BulletSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
    #endregion
}
