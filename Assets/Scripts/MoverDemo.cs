using UnityEngine;

public class MoverDemo : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float rotationSpeed = 90f;
    [SerializeField] private float reportAfterSeconds = 5f;

    private float elapsedTime;
    private bool reportedEndValues;

    private void Start()
    {
        Debug.Log($"MoverDemo start position: {transform.position}, rotation: {transform.rotation}");
    }

    private void Update()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime, Space.Self);
        // transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime, Space.Self);

        if (!reportedEndValues)
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= reportAfterSeconds)
            {
                Debug.Log($"MoverDemo end position: {transform.position}, rotation: {transform.rotation}");
                reportedEndValues = true;
            }
        }
    }
}
