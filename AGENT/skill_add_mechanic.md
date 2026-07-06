# Skill: Thêm & Quản Lý Mechanic (Add & Manage Mechanic)

Kỹ năng này bắt buộc AI phải tuân thủ đúng quy trình và cấu trúc khi tài liệu hóa hoặc sửa đổi bất kỳ cơ chế game (Mechanic), nguyên tố (Element), hình thái (Form), hay bộ biến đổi (Modifier) nào.

---

## 1. Cấu Trúc Bắt Buộc Cho File Mechanic

Mọi tài liệu mô tả chi tiết một Mechanic mới phải được trình bày theo cấu trúc sau:

```markdown
# [Tên Thành Phần - Ví dụ: Nguyên Tố Lửa (Fire Element)]

## 1. Thông Tin Định Danh (Metadata)
- **ID:** [MÃ_ĐỊNH_DANH_THEO_PREFIX]
  *(Xem quy chuẩn prefix tại Game_Knowledge_Base/01_Architecture_&_Data/Master_Tag_List.md)*
- **Phân loại:** [Form / Element / Modifier]
- **Tags liên quan:** `Tag1`, `Tag2`
  *(Chỉ sử dụng tag từ danh sách chuẩn hóa trong Game_Knowledge_Base/01_Architecture_&_Data/Master_Tag_List.md)*

## 2. Logic Vận Hành Cốt Lõi (Core Logic)
- [Mô tả chi tiết cách thức hoạt động cơ bản của mechanic này trong gameplay]
- [Các thông số ảnh hưởng trực tiếp]

## 3. Ma Trận Tương Tác Phát Sinh (Emergent Interactions)
- Liên kết dòng tương tác tương ứng trong: Game_Knowledge_Base/01_Architecture_&_Data/Interaction_Matrix.md
  *(Tuyệt đối không mô tả chi tiết cơ chế tương tác trực tiếp ở đây, chỉ link tới dòng tương ứng trong Interaction_Matrix.md)*

## 4. Hiện Thực Hóa Trong Code (Implementation Reference)
- Liên kết với: [Đường dẫn tương đối tới script cấu hình dữ liệu]
- Component chịu trách nhiệm xử lý: [Tên class component xử lý logic trong Unity]
```

---

## 2. Quy Trình Cập Nhật Hệ Thống

### Quy trình A: Thêm Mechanic Mới Vào Hệ Thống Đã Có
Khi tạo một mechanic mới, thực hiện các bước bắt buộc sau:
1. Tạo file mechanic mới theo đúng **Cấu trúc 4 phần** ở trên.
2. Rà soát toàn bộ các thành phần cùng loại hoặc tương thích đã tồn tại trong `Game_Knowledge_Base/`.
3. Với MỖI thành phần có khả năng tương tác phát sinh với mechanic mới này, bổ sung 1 dòng mới vào bảng tương tác tương thích trong [Interaction_Matrix.md](../Game_Knowledge_Base/01_Architecture_&_Data/Interaction_Matrix.md) (không sửa đổi nội dung file mechanic cũ).
4. Không được để trống mục **3. Ma Trận Tương Tác Phát Sinh** của file mới — tối thiểu phải liệt kê các link dẫn tới những dòng tương tác vừa được thêm trong [Interaction_Matrix.md](../Game_Knowledge_Base/01_Architecture_&_Data/Interaction_Matrix.md).

### Quy trình B: Sửa / Mở Rộng Mechanic Cũ
Nếu chỉ muốn chỉnh sửa hoặc thêm tương tác giữa các mechanic có sẵn:
1. Chỉ cập nhật trực tiếp tại file [Interaction_Matrix.md](../Game_Knowledge_Base/01_Architecture_&_Data/Interaction_Matrix.md).
2. Không viết lại hoặc sửa đổi toàn bộ file mechanic cũ, trừ khi có sự thay đổi lớn ở phần **Logic Vận Hành Cốt Lõi**.
