namespace Content.Server.Mech.Equipment.Components;

[RegisterComponent]
public sealed partial class MechRepairDroneComponent : Component
{
    /// <summary>
    /// The change in energy after each repair.
    /// </summary>
    [DataField("repairEnergyDelta")]
    public float RepairEnergyDelta = -30;

    /// <summary>
    /// Cooldown time between repairs.
    /// </summary>
    [DataField("repairCooldown")]
    public float RepairCooldown = 2f;

    /// <summary>
    /// Amount of damage repaired in one repair.
    /// </summary>
    [DataField("repairAmount")]
    public float RepairAmount = 10f;

    /// <summary>
    /// Is the repair module currently active?
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    public bool Active = false;

    /// <summary>
    /// Time accumulator for cooldown.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    public float CooldownAccumulator = 0f;
}
