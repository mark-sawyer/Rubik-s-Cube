using UnityEngine;
using UnityEngine.InputSystem;

internal class CameraMovement : MonoBehaviour {
    internal Vector2 Coords { get; private set; }
    private const float MAX_COORDINATE_MAGNITUDE = 2 * Mathf.PI / 5;
    private float magnitude;



    #region MonoBehaviour
    private void Start() {
        magnitude = transform.position.x;
    }
    private void Update() {
        updateCoordValues();
        updateCameraPosition();
    }
    #endregion



    #region private
    private void updateCoordValues() {
        Vector2 mouseDelta = Mouse.current.delta.ReadValue();
        Coords += mouseDelta / 500f;
        float magnitude = Coords.magnitude;
        if (magnitude > MAX_COORDINATE_MAGNITUDE) {
            Coords = Coords.normalized * MAX_COORDINATE_MAGNITUDE;
        }
    }
    private void updateCameraPosition() {
        float xPos = magnitude * Mathf.Cos(Coords.y) * Mathf.Cos(Coords.x);
        float zPos = magnitude * Mathf.Sin(Coords.x);
        float yPos = magnitude * Mathf.Sin(Coords.y) * Mathf.Cos(Coords.x);
        transform.position = new Vector3(xPos, yPos, zPos);
        transform.LookAt(Vector3.zero, Vector3.up);
    }
    #endregion
}
