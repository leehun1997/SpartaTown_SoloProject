using System;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownController controller;
    private Rigidbody2D movementRigidbody;
    private CharacterStatsHandler characterStatsHandler;
    private Camera camera;

    private Vector2 movementDirection;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
        characterStatsHandler= GetComponent<CharacterStatsHandler>();   
        camera = Camera.main;
    }
    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * characterStatsHandler.CurrentStat.speed;
        movementRigidbody.velocity = direction;
        Vector2 temCamera = camera.transform.position;

        temCamera += direction / (10*5); //왜 speed와 상관없이 50인가?
        camera.transform.position = new Vector3(temCamera.x, temCamera.y, -10);
    }

}