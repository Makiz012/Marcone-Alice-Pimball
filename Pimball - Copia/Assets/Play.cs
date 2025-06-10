using UnityEngine;

public class Play : MonoBehaviour
{
    public KeyCode flipKey = KeyCode.A; // Tecla para acionar o flipper
    private HingeJoint2D hinge;

    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
    }

    void Update()
    {
        JointMotor2D motor = hinge.motor;
        motor.motorSpeed = Input.GetKey(flipKey) ? 1000f : -1000f;
        hinge.motor = motor;
        hinge.useMotor = true;
    }
}