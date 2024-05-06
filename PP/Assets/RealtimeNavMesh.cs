using NavMeshPlus.Components;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealtimeNavMesh : MonoBehaviour
{

    public static RealtimeNavMesh Instance { get; private set; }

    NavMeshSurface navMeshSurface;

    private void Awake()
    {
        Instance = this;
        navMeshSurface = GetComponent<NavMeshSurface>();
    }

    public void GenerateNavMesh()
    {
        navMeshSurface.BuildNavMesh();
    }
}
