using System.Linq;
using System.Collections;
using UnityEngine;


internal class RotateFace : Rotater, IRotateFace {
    [SerializeField] private BoxCollider boxCollider;
    [SerializeField] private Transform cubiesTransform;
    private int cubeLayerMask;



    #region MonoBehaviour
    private void Start() {
        cubeLayerMask = LayerMask.GetMask("cube");
    }
    #endregion



    #region IRotateFace
    public void rotateClockwise() {
        if (InRotation) return;
        StartCoroutine(rotateFace(Rotations.frontClockwise));
    }
    public void rotateCounterclockwise() {
        if (InRotation) return;
        StartCoroutine(rotateFace(Rotations.frontCounterclockwise));
    }
    #endregion



    #region private
    private IEnumerator rotateFace(Quaternion rotation) {
        Transform[] cubieTransforms = getCubieTransforms();
        setThisAsParentToCubies(cubieTransforms);
        yield return rotate(rotation);
        reparentCubies();
    }
    private Transform[] getCubieTransforms() {
        Collider[] cubieColliders = Physics.OverlapBox(
            boxCollider.bounds.center,
            boxCollider.bounds.extents,
            transform.rotation,
            cubeLayerMask
        );
        return cubieColliders.Select(a => a.transform).ToArray();
    }
    private void setThisAsParentToCubies(Transform[] cubieTransforms) {
        foreach (Transform t in cubieTransforms) {
            t.SetParent(transform);
        }
    }
    private void reparentCubies() {
        int childCount = transform.childCount;
        Transform[] children = new Transform[childCount];
        for (int i = 0; i < childCount; i++) {
            children[i] = transform.GetChild(i);
        }
        foreach (Transform child in children) {
            child.SetParent(cubiesTransform);
        }
    }
    #endregion
}
