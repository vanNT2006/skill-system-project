# Skill: Thêm Kiến Thức (Add Knowledge)

Kỹ năng này hướng dẫn AI cách ghi nhận, phân loại và cập nhật kiến thức mới vào hệ thống tài liệu `Game_Knowledge_Base/`.

## Quy Trình Thực Hiện:

1. **Xác định phân loại kiến thức:**
   - Nếu là định hướng, triết lý chung -> Cập nhật vào [00_Overview_&_Design_Philosophy.md](../Game_Knowledge_Base/00_Overview_&_Design_Philosophy.md).
   - Nếu là cấu trúc code, quy chuẩn lập trình Unity -> Cập nhật vào [Unity_Structure_Guide.md](../Game_Knowledge_Base/01_Architecture_&_Data/Unity_Structure_Guide.md) hoặc [ScriptableObject_Templates.md](../Game_Knowledge_Base/01_Architecture_&_Data/ScriptableObject_Templates.md).
   - Nếu kiến thức là tương tác giữa các thành phần -> Luôn cập nhật vào [Interaction_Matrix.md](../Game_Knowledge_Base/01_Architecture_&_Data/Interaction_Matrix.md), không viết vào file triết lý hay cẩm nang cấu trúc code.

2. **Cập nhật Task & Dev Log:**
   - Sau khi thêm kiến thức mới dẫn đến công việc cần làm, ngay lập tức bổ sung task vào [Sprint_Current.md](../Game_Knowledge_Base/04_Dev_Logs_&_Tasks/Sprint_Current.md).

3. **Liên kết tài liệu:**
   - Sử dụng các liên kết markdown định dạng tương đối (ví dụ: `[Tên tài liệu](../../Game_Knowledge_Base/...)`) để liên kết chéo giữa các bài học, giúp việc tra cứu nhanh chóng.
