using UnityEngine;

public class Rotation : MonoBehaviour, ISpeedable
{
    [SerializeField] private Transform _transform;
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _speed;

    public float Speed => _speed;

    private void Update() =>
        Rotate();

    private void Rotate() =>
        _transform.Rotate(_direction * Utils.GetNormalizedValue(Speed));
}
