# CoreAdminPanel
پنل مدیریت مبتنی بر ASP.NET Core MVC برای مدیریت محصولات و شعب.


این پروژه یک پنل ادمین است که امکانات زیر را ارائه می‌دهد:
- CRUD محصولات
- CRUD شعب
- استفاده از Bootstrap و jQuery برای رابط کاربری
- معماری لایه‌ای با Services, Contracts و Utilities
- اتصال به SQL Server



## ویژگی‌ها
- مدیریت محصولات (ایجاد، ویرایش، حذف، مشاهده)
- مدیریت شعب (ایجاد، ویرایش، حذف، مشاهده)
- فرم‌ها با اعتبارسنجی سمت سرور و سمت کلاینت
- رابط کاربری ریسپانسیو با Bootstrap
- معماری تمیز و قابل توسعه


## پیش‌نیازها
- .NET 8 SDK یا نسخه‌ای که پروژه با آن ساخته شده
- SQL Server 2019 یا بالاتر
- Visual Studio 2022 یا VS Code



## نصب و اجرا
1. پروژه را کلون کنید:


git clone https://github.com/iamabolfazll/UIProject.git

2. دیتابیس SQL Server را بسازید و connection string را در `appsettings.json` تنظیم کنید
3. در Visual Studio پروژه را باز و Run کنید



## ساختار پروژه
- `Controllers` → کنترلرهای MVC
- `Views` → صفحات Razor
- `Models` → DTOها و Entityها
- `Services` → منطق تجاری
- `Contracts` → اینترفیس‌ها
- `Utilities` → ابزارهای کمکی




## تکنولوژی‌ها
- ASP.NET Core MVC
- C#
- SQL Server
- Bootstrap
- jQuery
