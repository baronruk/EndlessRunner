using UnityEngine;

public class SwerveMovement : MonoBehaviour
{

    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    private SwerveInputSystem _swerveInputSystem;
    [SerializeField] private float swerveSpeed = 0.8f;
    public float Speed = 10f;

    private void Awake()
    {
        _swerveInputSystem = GetComponent<SwerveInputSystem>();
    }

    private void Update()
    {
        float swerveAmount = Time.smoothDeltaTime * swerveSpeed * _swerveInputSystem.MoveFactorX;
        transform.Translate(swerveAmount, 0, 0);
        float maxPosX = Mathf.Clamp(transform.position.x, minX, maxX);
        transform.position = new Vector3(maxPosX, transform.position.y, transform.position.z);
        transform.position += transform.forward * Speed * Time.smoothDeltaTime;
    }
}
