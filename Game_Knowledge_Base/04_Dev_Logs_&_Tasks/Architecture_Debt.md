# Nợ Kỹ Thuật (Architecture Debt)

Nơi ghi lại các vấn đề về tối ưu hóa code, cấu trúc dự án cần được dọn dẹp hoặc nâng cấp trong tương lai (Refactoring).

## Vấn đề cần lưu ý (To Refactor)
* **Save/Load System:** Hiện tại chưa tích hợp Save/Load trạng thái nâng kỹ năng (có thể dùng PlayerPrefs hoặc JSON Serialize trong tương lai).
* **UI Scaling:** Đảm bảo UI Cây kỹ năng hoạt động tốt trên các độ phân giải màn hình khác nhau (Canvas Scaler).
* **Decoupling (Tách biệt logic):** Đảm bảo UI chỉ lắng nghe Event từ Manager chứ không can thiệp trực tiếp vào dữ liệu gốc của ScriptableObject.
