using System;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerInput", menuName = "SO/PlayerInput", order = 0)]
public class PlayerInputSO : ScriptableObject//, Controls.IPlayerActions
{
    public event Action<Vector2> OnMovementChange;
    public event Action OnAttackPressed;


}
