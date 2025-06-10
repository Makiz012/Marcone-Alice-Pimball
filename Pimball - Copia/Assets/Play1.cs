using UnityEngine;

public class FlipperController : MonoBehaviour
{
    public KeyCode flipKey = KeyCode.A; // Tecla para acionar o flipper
    public float motorSpeed = 1000f;    // Velocidade do motor
    private HingeJoint2D hinge;

    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
    }

    void Update()
    {
        JointMotor2D motor = hinge.motor;
        if (Input.GetKey(flipKey))
        {
            motor.motorSpeed = -motorSpeed; // Direção positiva
        }
        else
        {
            motor.motorSpeed = motorSpeed; // Direção negativa
        }
        hinge.motor = motor;
        hinge.useMotor = true;
    }
}