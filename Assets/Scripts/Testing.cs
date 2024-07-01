using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public int width = 50, height= 50;
    public float size = 10f;
    public Vector3 originPosition;

    private Grid grid;

    private void Start()
    {
        //grid = new Grid(width, height, size, originPosition);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
             grid.SetValue(GetMousePostition(),99);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(GetMousePostition()));
        }

    }

    private Vector3 GetMousePostition()
    {
        Vector3 vec = GetMousePostitionWithZ(Input.mousePosition, Camera.main);
        vec.z = 0f;
        return vec;
    }

    private Vector3 GetMousePostitionWithZ(Vector3 screenPosition, Camera worldCamera)
    {
        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
        return worldPosition;
    }

}
