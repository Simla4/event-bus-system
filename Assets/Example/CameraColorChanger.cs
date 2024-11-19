using System;
using sb.eventbus;
using UnityEngine;
using Random = UnityEngine.Random;

public class CameraColorChanger : MonoBehaviour
{
    [SerializeField] private Camera cam;
    
    private EventListener<OnPressSpaceEvent> onPressSpace;
    private void OnEnable()
    {
        onPressSpace = new EventListener<OnPressSpaceEvent>(ChangeCameraColor);
        EventBus<OnPressSpaceEvent>.AddListener(onPressSpace);
    }

    private void OnDisable()
    {
        EventBus<OnPressSpaceEvent>.RemoveListener(onPressSpace);
    }

    private void ChangeCameraColor(OnPressSpaceEvent e)
    {
        var r = Random.Range(0f, 1f);
        var g = Random.Range(0f, 1f);
        var b = Random.Range(0f, 1f);
        
        cam.backgroundColor = new Color(r, g, b);
    }
}
