using UnityEngine;
using UnityEngine.EventSystems;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;

    private Camera _camera;
    
    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject()) return; // block clicking on UI for Movement
        if (!Input.GetMouseButtonDown(0)) return;
        
        Vector3 mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
        _playerMovement.SetTarget(mousePos);
    }
}