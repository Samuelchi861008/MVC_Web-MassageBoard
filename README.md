# Massage Board 

使用 ASP.NET MVC 建立一個留言板網頁，透過連結資料庫，使用者可以達到 新增、修改、刪除、查看、查詢 等功能。使用者介面簡單易操作，使用者可較容易上手。 

## User Interface 

* 首頁

![image](https://github.com/Samuelchi861008/MVC_Web-MassageBoard/blob/master/homepage.png)

* 新增留言

![image](https://github.com/Samuelchi861008/MVC_Web-MassageBoard/blob/master/creat_1.png)
![image](https://github.com/Samuelchi861008/MVC_Web-MassageBoard/blob/master/creat_2.png)
![image](https://github.com/Samuelchi861008/MVC_Web-MassageBoard/blob/master/creat_3.png)

* 編輯留言 

![image](https://github.com/Samuelchi861008/MVC_Web-MassageBoard/blob/master/edit.png)

* 查看留言 

![image](https://github.com/Samuelchi861008/MVC_Web-MassageBoard/blob/master/check.png) 

* 刪除留言 

![image](https://github.com/Samuelchi861008/MVC_Web-MassageBoard/blob/master/delete.png)

## Features 

* 使用 ASP.NET MVC

![image](https://github.com/Samuelchi861008/MVC_Web-MassageBoard/blob/master/mvc.png)

* 使用 Bootstrap Datetimepicker 選擇日期

![image](https://github.com/Samuelchi861008/MVC_Web-MassageBoard/blob/master/datetimepicker.png)

使用 NuGet 安裝

```
> Install-Package Bootstrap.v3.Datetimepicker
```
```
> Install-Package Bootstrap.v3.Datetimepicker.CSS
```

於程式 head 地方加入連結

```HTML
  <script type="text/javascript" src="~/scripts/jquery-3.3.1.min.js"></script>
  <script type="text/javascript" src="~/scripts/moment.min.js"></script>
  <script type="text/javascript" src="~/scripts/bootstrap-datetimepicker.js"></script>
  <link rel="stylesheet" href="~/Content/bootstrap-datetimepicker.css" />
  <script type="text/javascript" src="~/scripts/bootstrap.min.js"></script>
```

使用 JQuary 調用

```javascript
<script type="text/javascript">
  /* 呼叫 datetimepicker */
  $(function () {
    $('#datepicker').datetimepicker({
      format: "YYYY/MM/DD"
    });
  });
</script>
```
