using UnityEngine;

public class Moving : MonoBehaviour, IMovable, ISpeedable
{
    [SerializeField] private float _speed;

    public float Speed => _speed;

    private void Update() =>
        Move();

    public void Move() =>
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
}
