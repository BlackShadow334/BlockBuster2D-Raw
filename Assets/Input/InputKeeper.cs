using UnityEngine;

public class InputKeeper : MonoBehaviour
{
    private static InputControls input_controls;

    private void Awake()
    {
        input_controls = new InputControls();
    }

    public static Vector2 PaddleMoveReadvalueVector2()
    {
        return input_controls.Paddle.Move.ReadValue<Vector2>();
    }

    public static bool PaddleTapBool()
    {
        return input_controls.Paddle.Tap.ReadValue<float>() == 1;
    }

    private void OnEnable() => input_controls.Enable();
    private void OnDisable() => input_controls.Disable();

}
