using System;
using sb.eventbus;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space");
            EventBus<OnPressSpaceEvent>.Emit(new OnPressSpaceEvent(1));
        }
    }
}
