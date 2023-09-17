using UnityEngine;

public class Scaling : MonoBehaviour, ISpeedable
{
    [SerializeField] private Transform _transform;
    [SerializeField] private Vector3 _maxLocalScale;
    [SerializeField] private float _speed;

    public float Speed => _speed;

    private void Update() =>
        Scale();

    private void Scale() =>
        _transform.localScale = Vector3.Lerp(_transform.localScale, _maxLocalScale, Utils.GetNormalizedValue(Speed * Time.deltaTime));
}
