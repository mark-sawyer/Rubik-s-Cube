using UnityEngine;

internal class PlotMouseCoordinates : MonoBehaviour {
    [SerializeField] private CameraMovement cameraMovement;
    [SerializeField] private RectTransform pointRT;
    private const float GRID_SIZE = 100f;



    private void Update() {
        Vector2 coords = cameraMovement.Coords;
        pointRT.anchoredPosition = coords * (2 * GRID_SIZE / Mathf.PI);
    }
}
