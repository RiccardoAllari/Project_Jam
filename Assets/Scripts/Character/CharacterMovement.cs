using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
	[SerializeField]
	private float speed;

	private CharacterController characterController;

	private void Awake()
	{
		characterController = GetComponent<CharacterController>();
	}

	private void Update()
	{
		this.transform.position += Vector3.right * speed * Time.deltaTime;
	}
}
