# 🌌 SkillSystemProject (Modular Skill Tree System)

[![Unity Version](https://img.shields.io/badge/Unity-6000.0.30f1-blue.svg?style=flat-flat)](https://unity.com/)
[![Language](https://img.shields.io/badge/Language-C%23-green.svg?style=flat-flat)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Platform](https://img.shields.io/badge/Platform-PC%20%7C%20Mobile-orange.svg?style=flat-flat)]()
[![License](https://img.shields.io/badge/License-MIT-brightgreen.svg?style=flat-flat)](LICENSE)

Dự án thực hành tự học Unity C# nhằm xây dựng một **Hệ thống Cây Kỹ Năng Modular (Modular Skill Tree System)**. Dự án được phát triển theo triết lý *Emergent Gameplay* (lối chơi phát sinh), nơi người chơi có thể tự do kết hợp các thành phần cơ bản để tạo ra các chiêu thức độc đáo của riêng mình (tương tự cơ chế chế phép trong *Noita* hay *Magicka*).

---

## 🏗️ Kiến Trúc Hệ Thống (Architecture Design)

Hệ thống được thiết kế theo hướng **Decoupled Architecture** (Giảm sự phụ thuộc chéo) và **Data-Driven** (Lấy dữ liệu làm trung tâm) sử dụng Unity ScriptableObjects:

```
                  ┌─────────────────────────┐
                  │   ScriptableObjects     │ <── (Dữ liệu tĩnh)
                  │    (SkillNodeData)      │
                  └────────────┬────────────┘
                               │
                               ▼
                  ┌─────────────────────────┐
                  │      SkillManager       │ <── (Logic cốt lõi & State)
                  └────────────┬────────────┘
                               │
            ┌──────────────────┴──────────────────┐
            ▼                                     ▼
┌───────────────────────┐             ┌───────────────────────┐
│     SkillTreeUI       │             │    PlayerController   │
│  (Hiển thị & Canvas)  │             │  (Thực thi chiêu thức)│
└───────────────────────┘             └───────────────────────┘
```

### Bộ Ghép Phép Thuật Modular:
* **Spell Form (Hình thái):** Định nghĩa cách kỹ năng bay/quét trong không gian (Đạn bay, Tia Laser, Vùng AoE...).
* **Spell Element (Nguyên tố):** Thuộc tính sát thương và các hiệu ứng trạng thái đi kèm (Hỏa, Băng, Lôi...).
* **Spell Modifier (Bộ biến đổi):** Thay đổi hành vi vật lý hoặc logic (Nảy đạn, Phân nhánh, Tự tìm mục tiêu...).

---

## 📁 Cấu Trúc Dự Án (Project Structure)

```text
├── 📂 AGENT/                       # Cấu hình luật và kỹ năng hỗ trợ của AI Assistant
│   ├── rules.md                    # Quy tắc lập trình và quy chuẩn chung cho AI
│   ├── skill_add_knowledge.md      # Quy trình cập nhật kiến thức
│   ├── skill_add_mechanic.md       # Quy trình thêm các cơ chế game
│   └── skill_assign_task.md        # Hướng dẫn chia nhỏ task và giao bài học
│
├── 📂 Game_Knowledge_Base/         # Hệ thống tài liệu tri thức (GDD & Tech Doc)
│   ├── 📂 01_Architecture_&_Data/  # Kiến trúc dữ liệu và ma trận tương tác
│   ├── 📂 02_Mechanics_Modules/    # Thư viện thiết kế Forms, Elements, Modifiers
│   ├── 📂 03_Interaction_Matrix/   # Logic phản ứng nguyên tố và vật lý môi trường
│   └── 📂 04_Dev_Logs_&_Tasks/     # Quản lý Sprint và nhật ký học tập (Learning Log)
│
└── 📂 Assets/                      # Mã nguồn và Tài nguyên Unity
    ├── 📂 Scripts/                 # Mã nguồn C#
    └── 📂 Settings/                # Cấu hình Universal Render Pipeline (URP)
```

---

## 📈 Lịch Sử & Tiến Độ Thực Hành (Roadmap)

Tiến trình học tập và hoàn thành các chức năng được ghi nhận chi tiết tại:
* 📝 [Learning_Log.md](Game_Knowledge_Base/04_Dev_Logs_&_Tasks/Learning_Log.md) - Ghi lại tiến độ làm các bài tập từ dễ đến khó.
* 📝 [Sprint_Current.md](Game_Knowledge_Base/04_Dev_Logs_&_Tasks/Sprint_Current.md) - Các task cần hoàn thành trong giai đoạn hiện tại.

---

## 💻 Cách Cài Đặt & Chạy Dự Án (Setup Instruction)

1. Tải và cài đặt **Unity Hub**.
2. Cài đặt phiên bản Unity tương thích (Khuyên dùng: **Unity 6000.0.x** hoặc mới hơn).
3. Clone project về máy:
   ```bash
   git clone https://github.com/vanNT2006/skill-system-project.git
   ```
4. Mở Unity Hub, chọn **Add** -> trỏ đến thư mục vừa clone để Import dự án.
