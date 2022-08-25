using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceService
{
    private static float _reachDistance = 2.0f;

    public static bool IsObjectWithinPlayerReach(Vector3 playerPosition, Vector3 objectPosition) {
        return Vector3.Distance(playerPosition, objectPosition) < _reachDistance;
    }
}
