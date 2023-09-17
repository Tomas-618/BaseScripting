using UnityEngine;

public class Moving : MonoBehaviour, IMovable, ISpeedable
{
    [SerializeField] private Transform _transform;
    [SerializeField] private float _speed;

    public float Speed => _speed;

    private void Update()
    {
        DrawRays();
        Move();
    }

    public void Move() =>
        _transform.Translate(Vector3.forward * Speed * Time.deltaTime);

    private void DrawRays()
    {
        float raysDistance = 1;

        Debug.DrawRay(_transform.position, _transform.forward * (raysDistance + _transform.localScale.z), Color.blue);
        Debug.DrawRay(_transform.position, _transform.up * (raysDistance + _transform.localScale.y), Color.green);
    }
}
