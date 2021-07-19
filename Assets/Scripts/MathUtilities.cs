using UnityEngine;

public static class MathUtilities
{
    // from https://forum.unity.com/threads/how-do-i-clamp-a-quaternion.370041/
    public static Quaternion ClampQuaternionYRotation(Quaternion q, int bounds)
    {
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1.0f;

        float angleX = 2.0f * Mathf.Rad2Deg * Mathf.Atan(q.x);
        angleX = Mathf.Clamp(angleX, -bounds, bounds);
        q.x = Mathf.Tan(0.5f * Mathf.Deg2Rad * angleX);
    
        return q;
    }
}
