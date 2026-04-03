using UnityEngine;
using UnityEngine.InputSystem;

internal class CubeInstructor : MonoBehaviour {
    private IRotateCube rotateCube;
    private IRotateFace rotateFace;


    private void Start() {
        rotateCube = GameObject.Find("cube").GetComponent<IRotateCube>();
        rotateFace = GameObject.Find("plane_front").GetComponent<IRotateFace>();
    }
    private void Update() {
        if (Keyboard.current.numpad8Key.wasPressedThisFrame) rotateCube.rightClockWise();
        if (Keyboard.current.numpad2Key.wasPressedThisFrame) rotateCube.rightCounterclockWise();
        if (Keyboard.current.numpad4Key.wasPressedThisFrame) rotateCube.topClockWise();
        if (Keyboard.current.numpad6Key.wasPressedThisFrame) rotateCube.topCounterclockWise();
        if (Keyboard.current.numpad5Key.wasPressedThisFrame) rotateCube.frontClockWise();
        if (Keyboard.current.numpad0Key.wasPressedThisFrame) rotateCube.frontCounterclockWise();

        if (Keyboard.current.gKey.wasPressedThisFrame) {
            rotateFace.rotateClockwise();
        }
        if (Keyboard.current.hKey.wasPressedThisFrame) {
            rotateFace.rotateCounterclockwise();
        }
    }
}
