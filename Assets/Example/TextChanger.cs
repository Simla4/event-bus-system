using System;
using System.Collections;
using System.Collections.Generic;
using sb.eventbus;
using TMPro;
using UnityEngine;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMesh;
    
    private EventListener<OnPressSpaceEvent> onPressSpace;
    private int value = 0;

    private void Start()
    {
        textMesh.text = value.ToString();
    }

    private void OnEnable()
    {
        onPressSpace = new EventListener<OnPressSpaceEvent>(ChangeText);
        EventBus<OnPressSpaceEvent>.AddListener(onPressSpace);
    }

    private void OnDisable()
    {
        EventBus<OnPressSpaceEvent>.RemoveListener(onPressSpace);
    }

    private void ChangeText(OnPressSpaceEvent e)
    {
        value += e.value;
        textMesh.text = value.ToString();
    }
}
