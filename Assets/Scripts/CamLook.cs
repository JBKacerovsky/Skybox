using System;
using UnityEngine; 
using UnityEngine.InputSystem; 

public class CamLook : MonoBehaviour
{
    [SerializeField] private float OrbitalSpeed = 1f; 
    private Input _input;
    private Action<InputAction.CallbackContext> _handler; 

    // Start is called before the first frame update
    void OnEnable()
    {
        _input = new Input(); 
        _input.Enable();
    }
    void OnDisable() => _input.Disable();
    void Start()
    {   
        // _handler allows easy subscribing unsubscribing
        _handler = (InputAction.CallbackContext ctx) => CamOrbit(ctx.ReadValue<Vector2>());

        // only subscribe to mouse possition input for changing cam rotatioin if left mouse key is pressed
        // there are probably more elegant w    ays of doing this rather than using one Action Map to subscribe/unsubscribe from a diffeernet input map
        // but this way works without any performance issues
        _input.Look.leftClick.started += ctx => StartLooking();
        _input.Look.leftClick.canceled += ctx => StopLooking();
    }

    private void CamOrbit(Vector2 coords)
    {
        // use mouseposition to set the rotation of the camera parent (this)
        // transform.eulerAngles.z *-1 makes sure the z angle always tends towards 0 to keep the camera relatively upright
        Quaternion current = transform.rotation; 
        Quaternion QT = current * Quaternion.Euler(coords.y, coords.x*-1, transform.eulerAngles.z *-1);
        QT = MathUtilities.ClampQuaternionYRotation(QT, 60);
        transform.rotation = Quaternion.Lerp(current, QT, Time.deltaTime*OrbitalSpeed);
    }

    private void StartLooking() => _input.Look.mousePosition.started += _handler;
    private void StopLooking() => _input.Look.mousePosition.started -= _handler;
}
