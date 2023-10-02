using UnityEngine;

public class Rotation : MonoBehaviour, ISpeedable
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _speed;

    public float Speed => _speed;

    private void Update() =>
        Rotate();

    private void Rotate() =>
        transform.Rotate(_direction * Utils.GetNormalizedValue(Speed));
}
