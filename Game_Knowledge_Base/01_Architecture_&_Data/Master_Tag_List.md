# Master Tag List & Quy Chuẩn ID

Tài liệu này định nghĩa danh sách các tag được chuẩn hóa và quy chuẩn đặt ID cho các thành phần trong game.

## 1. Quy Chuẩn Đặt ID
Mỗi thành phần trong game phải tuân theo prefix loại cụ thể sau:
* **Element (Nguyên tố):** `ELEM_TENVIETHOA` (ví dụ: `ELEM_FIRE`, `ELEM_WATER`, `ELEM_ELECTRIC`)
* **Form (Hình thái):** `FORM_TENVIETHOA` (ví dụ: `FORM_PROJECTILE`, `FORM_AOE`, `FORM_BEAM`)
* **Modifier (Bộ biến đổi):** `MOD_TENVIETHOA` (ví dụ: `MOD_HOMING`, `MOD_BOUNCING`, `MOD_PIERCING`)

## 2. Danh Sách Tag Chuẩn Hóa
AI **KHÔNG** được tự ý tạo tag mới khi viết file mechanic. Phải sử dụng các tag có sẵn dưới đây hoặc đề xuất bổ sung vào chính file này trước khi sử dụng.

| Tag | Ý Nghĩa / Mô Tả |
|:---|:---|
| `Damage` | Gây sát thương trực tiếp hoặc gián tiếp lên mục tiêu. |
| `Control` | Hạn chế khả năng di chuyển hoặc hành động (Làm chậm, Đóng băng, Choáng...). |
| `Movement` | Ảnh hưởng tới tốc độ di chuyển hoặc dịch chuyển vị trí (Tăng tốc, Dịch chuyển tức thời...). |
| `AoE` | Tác động diện rộng (Area of Effect). |
| `DoT` | Gây sát thương theo thời gian (Damage over Time). |
| `Combustible` | Dễ bắt lửa hoặc tương tác với nhiệt độ cao. |
| `Heat` | Tỏa nhiệt hoặc gây hiệu ứng bốc cháy. |
| `Light` | Phát sáng hoặc tương tác với ánh sáng, tầm nhìn. |
