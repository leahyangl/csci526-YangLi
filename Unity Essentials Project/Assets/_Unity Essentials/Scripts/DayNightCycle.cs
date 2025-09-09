using UnityEngine;

/// <summary>
/// This script slowly rotates a GameObject to simulate a day-night cycle.
/// It is intended to be attached to a Directional Light to create a moving sun/moon.
/// </summary>
public class DayNightCycle : MonoBehaviour
{
    // The duration of one full day in seconds.
    // This variable is public so it can be easily edited in the Unity Inspector.
    [Tooltip("The duration of one full day in seconds.")]
    public float dayDurationInSeconds = 60f;

    /// <summary>
    /// Update is called once per frame.
    /// </summary>
    void Update()
    {
        // Calculate the rotation speed in degrees per second.
        // A full day is a 360-degree rotation.
        float rotationSpeed = 360f / dayDurationInSeconds;

        // Rotate the light around the X-axis to simulate sunrise and sunset.
        // Time.deltaTime ensures the rotation is smooth and frame-rate independent.
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
