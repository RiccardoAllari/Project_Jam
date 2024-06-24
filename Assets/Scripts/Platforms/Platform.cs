using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Platform : ALevelElement
{
    #region Private enums
    private enum InputTypes { Horizontal, Vertical, Rotation }
    #endregion
    #region Private variables
    [SerializeField]
    private InputTypes inputTypes = InputTypes.Horizontal;
    [SerializeField]
    private float moveSpeed = 5.0f;
    [SerializeField]
    private float angleDegreeRotation = 90.0f;
    private Rigidbody rb;
    #endregion
    #region Private properties
    private Vector3 UserInput
    {
        get
        {
            float asseZ = Input.GetAxis("Horizontal");
            float asseY = Input.GetAxis("Vertical");
            return new Vector3(0.0f, asseY, asseZ);
        }
    }
    #endregion
    #region Lifecycle
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate() => Process(UserInput);
    #endregion
    protected override void Process(Vector3 input)
    {
        switch(inputTypes)
        {
            case InputTypes.Horizontal:
                rb.position += new Vector3(0.0f, 0.0f, input.z) * moveSpeed * Time.fixedDeltaTime;
                break;
            case InputTypes.Vertical:
                rb.position += new Vector3(0.0f, input.y, 0.0f) * moveSpeed * Time.fixedDeltaTime;
                break;
            default:
                if (Input.GetKeyDown(KeyCode.Space))
                    transform.rotation *= Quaternion.AngleAxis(angleDegreeRotation, Vector3.right);
                break;
        }
    }
}
