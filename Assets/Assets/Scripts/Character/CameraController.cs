using static Models;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("References")]
    public PlayerController playerController;
    [HideInInspector]
    public Vector3 targetRotation;
    public GameObject yGimbal;
    private Vector3 yGimbalRotation;

    [Header("Settings")]
    public CameraSettingsModel settings;

    #region - Update -

    private void Update()
    {
        CameraRotation();
        FollowPlayerCameraTarget();
    }

    #endregion

    #region - Position / Rotation -

    private void CameraRotation()
    {
        var viewInput = playerController.inputView;

        targetRotation.y += (settings.InvertedX ? -(viewInput.x * settings.SensitivityX) : (viewInput.x * settings.SensitivityX)) * Time.deltaTime;
        transform.rotation = Quaternion.Euler(targetRotation);

        yGimbalRotation.x += (settings.InvertedY ? (viewInput.y * settings.SensitivityY) : -(viewInput.y * settings.SensitivityY)) * Time.deltaTime;
        yGimbalRotation.x = Mathf.Clamp(yGimbalRotation.x, settings.YClampMin, settings.YClampMax);

        yGimbal.transform.localRotation = Quaternion.Euler(yGimbalRotation);
    }

    private void FollowPlayerCameraTarget()
    {
        transform.position = playerController.cameraTarget.position;
    }

    #endregion
}
