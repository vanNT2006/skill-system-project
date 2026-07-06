# Ma Trận Tương Tác (Interaction Matrix)

Tài liệu này là NGUỒN DUY NHẤT (single source of truth) cho mọi tương tác phát sinh giữa các Element / Form / Modifier. Không mô tả lại tương tác trong file mechanic riêng lẻ — chỉ link tới đây.

## Cách dùng
- Mỗi cặp thành phần chỉ được mô tả MỘT LẦN duy nhất tại đây.
- Định dạng dòng: `[ID_A] + [ID_B] -> [Mô tả hiệu ứng] | Ghi chú cân bằng (nếu có)`
- Khi thêm thành phần mới, phải bổ sung dòng tương tác với TẤT CẢ thành phần cùng nhóm tương thích đã tồn tại (xem quy trình trong [skill_add_mechanic.md](../../AGENT/skill_add_mechanic.md)).

## Bảng tương tác

### Element x Element
| Cặp | Hiệu ứng | Ghi chú |
|---|---|---|
| ELEM_FIRE + ELEM_WATER | Bốc hơi (Vaporize): Triệt tiêu thuộc tính Lửa, tạo ra màn sương làm giảm tầm nhìn của kẻ địch. | Cần điều chỉnh bán kính màn sương để tránh lag. |

### Element x Form
| Cặp | Hiệu ứng | Ghi chú |
|---|---|---|

### Element x Modifier
| Cặp | Hiệu ứng | Ghi chú |
|---|---|---|

### Form x Modifier
| Cặp | Hiệu ứng | Ghi chú |
|---|---|---|
