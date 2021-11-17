# Lists
## ListView
### ListView là control dùng để hiển thị tập hợp dữ liệu dưới dạng danh sách dọc.
>Các thuộc tính quan trọng:
+ x:Name="(1)" đặt định danh cho list liên kết với code behind (Có thể truyền bất cứ thứ gì vào (1), tại đây e đặt (1) là listView để sử dụng cho các phần sau).
+ IsGroupingEnabled="True/False" cho phép gộp các bản ghi vào một nhóm.
+ IsPullToRefreshEnabled="True/False" cho phép kéo listview xuống để làm mới dữ liệu.
+ GroupDisplayBinding="{Binding (2)}" cho phép truyền các tên của group. (2) có thể text hoặc giá trị thuộc tính của đối tượng.
+ HasEvenRow="True/False" dùng để tự động điều chỉnh kích thước chiều cao hàng cho vừa với nội dung.
>Một số thuộc tính gọi hàm của ListView:
+ Refreshing="" được sử dụng khi refesh List
+ ItemSelected="" được sử dụng khi có Item được chọn
+ ItemTapped="" được sử dụng khi có Item được tap

*(Các sự kiện ItemSelected, ItemTapped đều được gắn với một CommandParameter)*
  *(sự kiện tap sẽ xảy ra trước sự kiện chọn)*
>Tạo ItemTemplate cho ListView
+ Sử dụng cặp thẻ 
```
<ListView.ItemTemplate>
  <DataTemplate>
    (3)
  </DataTemplate>
<ListView.ItemTemplat>
```
Trong (3) có thể là các cặp thẻ Cell:

  Các `<TextCell></TextCell>` - Dòng dữ liệu dạng text

  Các `<ImageCell></ImageCell>` - Dòng dữ liệu chứa ảnh

  Hoặc 
  `<ViewCell></ViewCell>` - Dòng dữ liệu được custorm theo ý người dùng
  >Nạp dữ liệu vào ListView

+ Hard Code (đối với dữ liệu cố định và xác định, không áp dụng ItemTemplate)
  
  ```
  <ListView.ItemSource>
  
        <x:Array Type="{x:Type x:String}">
        
              <x:String>   </x:String>
              
        </x:Array>
        
  </ListView.ItemSource>
  ```
 + Nạp bằng code behind (đối với dữ liệu có thể thay đổi trong quá trình sử dụng ứng dụng)
 
    `listView.ItemSource = <Nguồn dữ liệu>;`
  
   *(Nguồn dữ liệu có thể là: Array, List<T>, IEnumable<T>, ObservableCollection<T> ....)*
   
>ActionConText
 + Là thuộc tính của các cell, quy định một hành động khi tương tác với cell (ấn giữ với android, kéo sang trái với Apple).
 + Các dùng trong mỗi cặp thẻ Cell chứa cặp thẻ 
   ```
   <<Cell>.ActionContext>
        <MenuItem Tex="<Tên tùy chọn>" Clicked="<Sự kiện được gọi>"/>
   </<Cell>.ActionContext>
   ```
>Thiết lập Footer, Header cho ListView

+ Với Footer/Header là Text
  Sử dụng thuộc tính Header="<String>", Footer="<String>" ngay tại ListView.
+ Với Footer/Header là View 

  Footer: Sử dụng cặp thẻ ```<ListView.FooterTemplate>View</ListView.FooterTemplate>```
  
  Header: Sử dụng cặp thẻ ```<ListView.HeaderTemplate>View</ListView.HeaderTemplate>```
  
 ## CommandParameter
 + Là tham số truyền vào các sự kiện xác định phạm vi dữ liệu mà sự kiện có tác dụng hoặc có thể tác động tới
 + Cách dùng: Sử dụng CommandParameter ngay tại nơi phát sinh sự kiện với syntax:
 ` CommandParameter="{Binding (4)}" `
 Trong (4) có thể là biến thuộc tính, string, ... hoặc dấu "." nếu muốn tác động đến toàn bộ bản ghi.
 ## SearchBar
 + Là một control cho phép tìm kiếm và hiển thị kết quả trên ListView
 >Một số thuộc tính gọi hàm:
   + OnTextChange="" - gọi hàm khi nhập text vào ô tìm kiếm
   + Focused="" - gọi hàm khi nhấp vào ô tìm kiếm
 
 
