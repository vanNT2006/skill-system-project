using UnityEngine;

public enum SkillType
{
    Elemental,
    Form,
    Passive
}

[CreateAssetMenu(fileName = "NewSkillNodeData", menuName = "Skills/SkillNodeData")]
public class SkillNodeData : ScriptableObject
{
    [Header("Thông tin định danh")]
    [SerializeField]
    [Tooltip("ID duy nhất của kỹ năng (Ví dụ: ELEM_FIRE, FORM_PROJECTILE)")]
    private string _id;
    public string Id => _id;

    [SerializeField]
    [Tooltip("Tên hiển thị của kỹ năng")]
    private string _name;
    public string Name => _name;

    [SerializeField]
    [Tooltip("Loại kỹ năng (ví dụ: Elemental, Form, Passive]")]
    private SkillType _type;
    public SkillType Type => _type;

    [SerializeField]
    [Tooltip("Mô tả của kỹ năng")]
    private string _description;
    public string Description => _description;

    [SerializeField]
    [Tooltip("Hình ảnh đại diện của kỹ năng")]
    private Sprite _icon;
    public Sprite Icon => _icon;

    [Header("Yêu cầu")]
    [SerializeField]
    [Tooltip("Danh sách các kỹ năng cần thiết để mở khóa kỹ năng này")]
    private SkillNodeData[] _requiredSkills;
    public SkillNodeData[] RequiredSkills => _requiredSkills;

    [SerializeField]
    [Tooltip("Điểm cần thiết để mở khóa kỹ năng này")]
    private int _requiredPoints;
    public int RequiredPoints => _requiredPoints;

    [Header("Trạng thái")]
    [field: SerializeField] 
    [field: Tooltip("Trạng thái mở khóa của kỹ năng")]
    public bool IsUnlocked { get; set; } = false;
}
