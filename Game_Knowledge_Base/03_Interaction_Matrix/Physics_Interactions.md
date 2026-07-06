# Tương Tác Vật Lý (Physics Interactions)

Định nghĩa cách các kỹ năng tương tác với môi trường vật lý, lực tác động và địa hình trong Unity.

## 1. Lực và Động Lượng (Force & Momentum)
* **Knockback (Hất văng):** Đẩy kẻ địch ra xa khỏi tâm vụ nổ hoặc hướng bắn của đạn. Sử dụng `Rigidbody2D.AddForce` hoặc `Rigidbody.AddForce`.
* **Pull / Vortex (Lực hút / Hố đen):** Kéo kẻ địch về một điểm trung tâm. Lực hút tỉ lệ nghịch với khoảng cách từ kẻ địch đến tâm hút.

## 2. Tương Tác Địa Hình (Terrain Interactions)
* **Destructible Terrain (Địa hình phá hủy được):** Một số kỹ năng có thể phá hủy các chướng ngại vật (ví dụ: dùng lửa đốt cỏ, dùng vụ nổ phá đá).
* **Gravity (Trọng lực):** Đạn bay chịu ảnh hưởng của trọng lực (quỹ đạo parabol).
