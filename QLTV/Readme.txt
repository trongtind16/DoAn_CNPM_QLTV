Để chạy được source code mẫu:
1. Install SQL Server >= 2010
	- Start service SQL Server!!!
2. Instal VS >= 2010

-------------
Cách run chi tiết:
1. Vào thư mục:
	...\QLTV
2.1. Mở file
	CreateDB11.cmd bằng Notepad++
	Thay thế chuỗi
	DESKTOP-EA2GQC6---> thành {server name}\{Instance Name của SQL Server} trên máy đang chạy
	và lưu lại
	
2.2  Double click và file:
	CreateDB.cmd
	
3. Open SQL Server Management Studio & kiểm tra	database 
	[QLTV] được tạo
	
4. Open Solution {QLTV.sln} bằng Visual Studio
5. Vào project: 
	QLTV
6. Double click để open file:
		App.config
7. Cập nhật chuỗi kết nối:
<add key="ConnectionString" value="Data Source=DESKTOP-EA2GQC6;Initial Catalog=QLHS;Integrated Security=True"/>
bằng cách đổi:
	L8PC149\SQLEXPRESS ---> thành {server name}\{Instance Name của SQL Server} trên máy đang chạy
8. Lưu file:
	App.config
9. Build solution tiếp tục

Chúc các bạn may mắn!!!	
	
	
		