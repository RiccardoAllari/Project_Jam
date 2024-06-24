using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Obstacle : MonoBehaviour
{
	[SerializeField]
	private float effectTime;
	[SerializeField]
	private float cooldownTime;
	protected abstract void Effect();
}
