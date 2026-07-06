# ScriptableObject Templates

Tài liệu này phác thảo cấu trúc của các ScriptableObject dùng để cấu hình dữ liệu kỹ năng.

## 1. SkillBase (ScriptableObject gốc)
Lưu trữ thông tin cơ bản của một node kỹ năng trên cây kỹ năng.

```csharp
using UnityEngine;

[CreateAssetMenu(fileName = "NewSkill", menuName = "Skills/Skill Node")]
public class SkillNodeData : ScriptableObject
{
    public string id;
    public string skillName;
    [TextArea] public string description;
    public Sprite icon;
    
    [Header("Requirements")]
    public int cost = 1;
    public SkillNodeData[] prerequisites; // Kỹ năng cần mở trước
    
    [Header("Status")]
    public bool isUnlocked = false; // Trạng thái mở khóa
}
```

## 2. SpellComponent (Dành cho việc ghép chiêu thức)
Dành cho hệ thống chế kỹ năng (nếu có):
* **SpellForm:** Hình thái (Projectile, Ray, Zone...)
* **SpellElement:** Nguyên tố (Fire, Ice, Light...)
* **SpellModifier:** Bộ biến đổi (Fork, Bounce, Piercing...)
