using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Public Variables
    public float PlayerSpeed = 6.2f;
    #endregion

    #region Private Variables
    private Transform _targetTransform;
    private float hInput;
    private float vInput;
    #endregion

    #region Public Methods
    #endregion

    #region Private Methods
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        _targetTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    private void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        _targetTransform.position += new Vector3(hInput, vInput, 0f) * PlayerSpeed * Time.deltaTime;
        CheckPlayerOutOfBounds();
    }

    private void CheckPlayerOutOfBounds()
    {
        _targetTransform.position = new Vector3(
                    Mathf.Clamp(_targetTransform.position.x, -8.088f, 8.088f),
                    Mathf.Clamp(_targetTransform.position.y, -4.199f, 2.1f),
                    _targetTransform.position.z);
    }
    #endregion
}
