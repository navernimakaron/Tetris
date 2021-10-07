using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoundaries : MonoBehaviour
{
    [SerializeField] private Transform leftSide;
    [SerializeField] private Transform rightSide;
    [SerializeField] private float minDistance = 0.1f;
    [SerializeField] private LayerMask layerMask;
    
    private Vector3 _right = Vector3.right;
    private Vector3 _left = Vector3.left;

    public bool IsBorder { get; private set; }

    private void FixedUpdate()
    {
        CheckForBorders(leftSide, _left);
        if (IsBorder == false)
            CheckForBorders(rightSide, _right);
    }

    private void CheckForBorders(Transform side, Vector3 direction)
    {
        var raycastHit = Physics2D.Raycast(
            side.position,
            Vector2.left,
            minDistance,
            layerMask);

        Debug.DrawRay(side.position, direction * minDistance, Color.magenta);

        IsBorder = raycastHit.collider != null;
    }
}