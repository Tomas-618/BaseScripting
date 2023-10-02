using UnityEngine;

public class MovingToPoint : MonoBehaviour, IMovable, ISpeedable
{
    [SerializeField] private Transform _arrivalPoint;
    [SerializeField] private float _speed;

    public float Speed => _speed;

    private void Update() =>
        Move();

    public void Move() =>
        transform.position = Vector3.Lerp(transform.position, _arrivalPoint.position, Utils.GetNormalizedValue(Speed * Time.deltaTime));
}
