using UnityEngine;

public class UnparentAndFollow : MonoBehaviour
{
    private Transform target;
    private Vector3 offset;
    private void Awake()
    {
        offset = transform.localPosition;
        target = transform.parent;
        transform.parent = null;
    }
    private void Update()
    {
        transform.position = target.position + offset;
    }
}
