using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Routing : MonoBehaviour
{
    [SerializeField]
    private Transform[] wayPoints;

    private Vector3 gizmosPosition;

    private void OnDrawGizmos()
    {
        for (float t = 0; t <= 1; t += 0.05f)
        {
            gizmosPosition = Mathf.Pow(1 - t, 3) * wayPoints[0].position + 3 * Mathf.Pow(1 - t, 2) * t * wayPoints[1].position + 3 * (1 - t) * Mathf.Pow(t, 2) * wayPoints[2].position + Mathf.Pow(t, 3) * wayPoints[3].position;

            Gizmos.DrawSphere(gizmosPosition, 0.25f);
        }

        Gizmos.DrawLine(new Vector3(wayPoints[0].position.x, wayPoints[0].position.y, wayPoints[0].position.z), new Vector3(wayPoints[1].position.x, wayPoints[1].position.y, wayPoints[1].position.z));
        Gizmos.DrawLine(new Vector3(wayPoints[2].position.x, wayPoints[2].position.y, wayPoints[2].position.z), new Vector3(wayPoints[3].position.x, wayPoints[3].position.y, wayPoints[3].position.z));

    }
}
