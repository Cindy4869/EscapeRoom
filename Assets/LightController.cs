using UnityEngine;
using UnityEngine.InputSystem;

public class LightController : MonoBehaviour
{

    public Light light;
    public InputActionReference action;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        light = GetComponent<Light>();

        action.action.Enable();
        action.action.performed += ctx =>
        {
            light.color = new Color(Random.value, Random.value, Random.value);
        };
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.tabKey.wasPressedThisFrame)
        {
            light.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
