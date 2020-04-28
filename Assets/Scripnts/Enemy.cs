﻿using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] private float speed = 10f;

    private Transform _target;
    private int _wavepointIndex = 0;

    private void Start()
    {
        _target = Waypoints.points[0];
    }

    private void Update()
    {
        Vector3 dir = _target.position - transform.position;
        transform.Translate(dir.normalized * (speed * Time.deltaTime));

        if (Vector3.Distance(transform.position, _target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
    }

    private void GetNextWaypoint()
    {
        if (_wavepointIndex >= Waypoints.points.Length)
        {
            Destroy(gameObject);
            return;
        }

        _wavepointIndex++;
        _target = Waypoints.points[_wavepointIndex];
    }
}
