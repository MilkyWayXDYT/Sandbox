using System;
using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour
{
    [SerializeField] private UnityEvent onOpened;

    public event Action<Door> Opened;

    private bool _isOpen;

    public void Open()
    {
        if (_isOpen) return;
        _isOpen = true;

        onOpened.Invoke();
        Opened?.Invoke(this);
    }
}
