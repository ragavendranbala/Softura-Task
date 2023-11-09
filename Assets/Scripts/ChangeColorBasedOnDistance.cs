using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorBasedOnDistance : MonoBehaviour
{
    [SerializeField] private LayerMask layerToCheck = 1 << 6;
    [SerializeField] private float distanceCheckRadius = 2f;
    [SerializeField] private Color colorToChange = Color.red;

    private Color _defaultColor;
    private Renderer _renderer;
    private Color _currentColor;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        _defaultColor = _renderer.material.color;
        _currentColor = _defaultColor;
    }

    private void Update()
    {
        if (Physics.CheckSphere(transform.position, distanceCheckRadius, layerToCheck))
        {
            ChangeTheColor();
        }
        else
        {
            ChangeToDefaultColor();
        }
    }

    private void ChangeToDefaultColor()
    {
        if (_currentColor == _defaultColor)
            return;

        _renderer.material.color = _defaultColor;
        _currentColor = _defaultColor;
    }

    private void ChangeTheColor()
    {
        if (_currentColor == colorToChange)
            return;

        _renderer.material.color = colorToChange;
        _currentColor = colorToChange;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position, distanceCheckRadius);
    }
}