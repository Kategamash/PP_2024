using NavMeshPlus.Components;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealtimeNavMesh : MonoBehaviour
{
    NavMeshSurface navMeshSurface;

    void Start()
    {
        navMeshSurface = GetComponent<NavMeshSurface>();
    }

    void Update()
    {
        navMeshSurface.BuildNavMesh();
    }
}
