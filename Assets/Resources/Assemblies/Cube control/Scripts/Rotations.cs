using UnityEngine;

internal static class Rotations {
    internal static readonly Quaternion frontClockwise = Quaternion.Euler(90f, 0f, 0f);
    internal static readonly Quaternion frontCounterclockwise = Quaternion.Euler(-90f, 0f, 0f);
    internal static readonly Quaternion rightClockwise = Quaternion.Euler(0f, 0f, 90f);
    internal static readonly Quaternion rightCounterclockwise = Quaternion.Euler(0f, 0f, -90f);
    internal static readonly Quaternion topClockwise = Quaternion.Euler(0f, 90f, 0f);
    internal static readonly Quaternion topCounterclockwise = Quaternion.Euler(0f, -90f, 0f);
}
