using UnityEngine;

public class Obstacle : MonoBehaviour {
    private enum RotationState {
        Forward,
        Right,
        Down,
    }

    [SerializeField] private float rotationSpeed = 30f;
    [SerializeField] private RotationState rotationState; // 障碍物旋转的方式

    private Transform parentPos; // 旋转圆心坐标

    private void Start() {
        parentPos = transform.parent;
    }

    private void Update() {
        ObstacleRotation();
    }

    private void ObstacleRotation() {
        switch (rotationState) {
            default:
            case RotationState.Forward:
                transform.RotateAround(parentPos.position, Vector3.forward, rotationSpeed * Time.deltaTime);
                break;
            case RotationState.Right:
                transform.RotateAround(parentPos.position, Vector3.right, rotationSpeed * Time.deltaTime);
                break;
            case RotationState.Down:
                transform.RotateAround(parentPos.position, Vector3.down, rotationSpeed * Time.deltaTime);
                break;
        }
    }
}