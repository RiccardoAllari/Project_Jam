using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ALevelElement : MonoBehaviour
{
    #region Protected methods
    protected abstract void Process(Vector3 input);
    #endregion
}
