FCFS (First Come First Served)
 
 P                    Thời gian đến (Arrival time)         Thời gian sử dụng CPU (Burst time)
 P1								0										24						
 P2								1										3
 P3								2										3
 
 Tính thời gian đáp ứng trung bình, tigna hoàn thành trung bình, Tgian chờ Trung bình
 
 
 Biểu đồ Gantt:
 
 P1						P2						P3
 
0						24						27			30

FCFS: tiêu chí lựa chọn tiến trình: Phụ thuộc vào thứ tự hàng đợi

- Thời gian đáp ứng: tgian sử dụng CPU của tiến trình trước - Tgian sd SPU của tiền trình trước đó
P1: 0 -0 = 0
P2: 24 - 1 =23
P3: 27 - 2 = 25
AVG = 16

- Thời gian hoàn thành: tgian kể từ lúc tiến trình vào hàng đợi đến khi xử lý xong 
P1: 24 - 0 =24
P2: 27 - 1 = 26
P3: 30 - 2 = 28
AVG: 26

- Thời gian chờ: Nhập CPU. Tgian hoàn thành - tgian sử dụng CPU
P1: 24 - 24 = 0
P2: 26 - 3 = 23
P3: 28 - 3 = 25
AVG: 16 


==========================================
SJF: Shortest Job First - chọn công việc ngắn nhất làm

 P                    Thời gian đến (Arrival time)         Thời gian sử dụng CPU (Burst time)
 P1								0										6						
 P2								1										8
 P3								2										4
 P4								3										2
 
  Tính thời gian đáp ứng trung bình, tigna hoàn thành trung bình, Tgian chờ Trung bình
  
  Biểu đồ Gantt:

- Độc quyền: nào vào trước -> chạy hết tiến trình -> xét tg nào sử dụng ít hơn để chạy tiếp
P1						P4						P3			P2						
 
0						6						8			12			20			
  
- Không độc quyền: Ngắt giữa chừng -> canh tgian sử dụng CPU của từng tiến trình -> Tiến trình nào nhỏ chạy trước
 
P1						P4						P1			P3			P2				
 
0						3						5			8			12			20