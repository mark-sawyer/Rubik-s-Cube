
internal class RotateCube : Rotater, IRotateCube {
    #region IRotateCube
    public void frontClockWise() {
        if (InRotation) return;
        StartCoroutine(rotate(Rotations.frontClockwise));
    }
    public void frontCounterclockWise() {
        if (InRotation) return;
        StartCoroutine(rotate(Rotations.frontCounterclockwise));
    }
    public void rightClockWise() {
        if (InRotation) return;
        StartCoroutine(rotate(Rotations.rightClockwise));
    }
    public void rightCounterclockWise() {
        if (InRotation) return;
        StartCoroutine(rotate(Rotations.rightCounterclockwise));
    }
    public void topClockWise() {
        if (InRotation) return;
        StartCoroutine(rotate(Rotations.topClockwise));
    }
    public void topCounterclockWise() {
        if (InRotation) return;
        StartCoroutine(rotate(Rotations.topCounterclockwise));
    }
    #endregion
}
