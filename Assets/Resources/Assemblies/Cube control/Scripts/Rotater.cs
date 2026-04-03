using System.Collections;
using UnityEngine;

internal abstract class Rotater : MonoBehaviour {
    internal bool InRotation { get; private set; }



    internal IEnumerator rotate(Quaternion rotation) {
        InRotation = true;
        float time = 0f;
        Quaternion startRotation = transform.rotation;
        Quaternion targetRotation = rotation * startRotation;
        while (time < RotationSpeed.Value) {
            transform.rotation = Quaternion.Slerp(
                startRotation,
                targetRotation,
                time / RotationSpeed.Value
            );
            time += Time.deltaTime;
            yield return null;
        }
        transform.rotation = targetRotation;
        InRotation = false;
    }
}
