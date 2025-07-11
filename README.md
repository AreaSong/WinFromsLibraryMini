# WinForms图书管理系统 📚

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-blue.svg)](https://dotnet.microsoft.com/download/dotnet-framework)
[![Entity Framework](https://img.shields.io/badge/Entity%20Framework-6.2.0-green.svg)](https://docs.microsoft.com/en-us/ef/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-2012+-red.svg)](https://www.microsoft.com/sql-server)
[![License](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

一个基于C# WinForms开发的图书管理系统，采用三层架构设计，实现了完整的图书借阅管理功能。该项目适合作为毕业设计或学习C# WinForms开发的参考项目。

## 📋 项目概述

### 主要功能
- 🔐 **用户认证系统** - 支持邮箱登录和验证码验证
- 📖 **图书管理** - 图书信息维护、库存管理
- 📝 **借阅管理** - 图书借阅、归还、记录查询
- 👥 **用户管理** - 用户信息管理、权限控制
- 📊 **数据统计** - 借阅记录统计和管理

### 技术栈
- **开发语言**: C#
- **UI框架**: Windows Forms
- **数据访问**: Entity Framework 6.2.0 (Database First)
- **数据库**: SQL Server 2012+
- **开发环境**: .NET Framework 4.8
- **开发工具**: Visual Studio 2022

## 🏗️ 系统架构

### 三层架构设计

```
┌─────────────────────────────────────────────────────────────┐
│                    表示层 (UI Layer)                        │
│  ┌─────────────────┐ ┌─────────────────┐ ┌─────────────────┐ │
│  │   LoginForm     │ │  BookManager    │ │  UserControls   │ │
│  └─────────────────┘ └─────────────────┘ └─────────────────┘ │
└─────────────────────────────────────────────────────────────┘
                              │
┌─────────────────────────────────────────────────────────────┐
│                  业务逻辑层 (BLL Layer)                      │
│  ┌─────────────────┐ ┌─────────────────┐ ┌─────────────────┐ │
│  │   LoginBLL      │ │ BookManagerBLL  │ │   ManagerBLL    │ │
│  └─────────────────┘ └─────────────────┘ └─────────────────┘ │
└─────────────────────────────────────────────────────────────┘
                              │
┌─────────────────────────────────────────────────────────────┐
│                  数据访问层 (DAL Layer)                      │
│  ┌─────────────────┐ ┌─────────────────┐ ┌─────────────────┐ │
│  │   LoginDAL      │ │ BookManagerDAL  │ │   ManagerDAL    │ │
│  └─────────────────┘ └─────────────────┘ └─────────────────┘ │
└─────────────────────────────────────────────────────────────┘
                              │
┌─────────────────────────────────────────────────────────────┐
│                   数据模型层 (Models)                        │
│  ┌─────────────────┐ ┌─────────────────┐ ┌─────────────────┐ │
│  │      User       │ │      Book       │ │  BorrowRecord   │ │
│  └─────────────────┘ └─────────────────┘ └─────────────────┘ │
└─────────────────────────────────────────────────────────────┘
                              │
┌─────────────────────────────────────────────────────────────┐
│                    数据库层 (Database)                       │
│                      SQL Server                             │
└─────────────────────────────────────────────────────────────┘
```

### 各层职责

| 层次 | 项目名称 | 主要职责 |
|------|----------|----------|
| **UI层** | WinFromsLibraryMini | 用户界面展示、用户交互处理 |
| **BLL层** | LibraryBLL | 业务逻辑处理、数据验证 |
| **DAL层** | LibraryDAL | 数据访问、数据库操作 |
| **Models层** | LibraryModels | 实体模型、数据结构定义 |

## ✨ 功能特性

### 🔐 用户认证系统
- **登录验证**: 邮箱 + 密码 + 验证码三重验证
- **验证码**: 动态生成4位字母数字混合验证码
- **会话管理**: 登录状态保持和用户信息传递

```csharp
// 登录验证核心代码
public User Login(string email, string password)
{
    return _DbContext.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
}
```

### 📖 图书管理功能
- **图书展示**: DataGridView展示图书列表
- **图书借阅**: 一键借阅，自动减少库存
- **库存管理**: 实时库存更新和显示

### 📝 借阅记录管理
- **借阅记录**: 完整的借阅历史记录
- **归还管理**: 图书归还和库存恢复
- **状态跟踪**: 借阅状态实时更新

```csharp
// 图书归还核心代码
public int ReturnBook(int RecordId)
{
    borrowRecord = _DbContext.BorrowRecords.FirstOrDefault(b => b.RecordId == RecordId);
    borrowRecord.ReturnDate = DateTime.Now;
    AddStock(borrowRecord.BookId);  // 恢复库存
    _DbContext.SaveChanges();
    return 1;
}
```

### 👥 用户管理功能
- **用户列表**: 查看所有注册用户
- **用户删除**: 管理员权限用户删除
- **权限控制**: 基于角色的功能访问控制

## 🗄️ 数据库设计

### 核心数据表

#### Users 用户表
| 字段名 | 数据类型 | 说明 |
|--------|----------|------|
| UserId | int (PK) | 用户ID |
| Username | nvarchar(50) | 用户名 |
| Password | nvarchar(50) | 密码 |
| Role | nvarchar(20) | 用户角色 |
| Email | nvarchar(100) | 邮箱地址 |
| Phone | nvarchar(20) | 电话号码 |

#### Books 图书表
| 字段名 | 数据类型 | 说明 |
|--------|----------|------|
| BookId | int (PK) | 图书ID |
| Title | nvarchar(100) | 书名 |
| Author | nvarchar(50) | 作者 |
| Publisher | nvarchar(50) | 出版社 |
| ISBN | nvarchar(20) | ISBN号 |
| Price | decimal(10,2) | 价格 |
| Stock | int | 库存数量 |
| Summary | nvarchar(500) | 图书简介 |

#### BorrowRecords 借阅记录表
| 字段名 | 数据类型 | 说明 |
|--------|----------|------|
| RecordId | int (PK) | 记录ID |
| UserId | int (FK) | 用户ID |
| BookId | int (FK) | 图书ID |
| BorrowDate | datetime | 借阅日期 |
| ReturnDate | datetime | 归还日期 |

## 📁 项目结构

```
WinFromsLibraryMini/
├── WinFromsLibraryMini/           # 主应用程序项目
│   ├── Forms/                     # 窗体文件夹
│   │   ├── LoginForm.cs          # 登录窗体
│   │   ├── BookManager.cs        # 主管理窗体
│   │   ├── baseForm.cs           # 基础窗体类
│   │   └── UsersC/               # 用户控件
│   │       ├── BookManagerUserControl.cs    # 图书管理控件
│   │       ├── ManagerUserControl.cs        # 管理员控件
│   │       └── UsersUserControl.cs          # 用户管理控件
│   ├── Program.cs                # 程序入口点
│   ├── App.config               # 应用程序配置
│   └── packages.config          # NuGet包配置
├── LibraryBLL/                   # 业务逻辑层
│   ├── LoginBLL.cs              # 登录业务逻辑
│   ├── BookManagerBLL.cs        # 图书管理业务逻辑
│   ├── ManagerBLL.cs            # 管理员业务逻辑
│   └── UsersBLL.cs              # 用户管理业务逻辑
├── LibraryDAL/                   # 数据访问层
│   ├── LoginDAL.cs              # 登录数据访问
│   ├── BookManagerDAL.cs        # 图书管理数据访问
│   ├── ManagerDAL.cs            # 管理员数据访问
│   └── UsersDAL.cs              # 用户管理数据访问
├── DbHelp/ (LibraryModels)       # 数据模型层
│   ├── User.cs                  # 用户实体类
│   ├── Book.cs                  # 图书实体类
│   ├── BorrowRecord.cs          # 借阅记录实体类
│   ├── WinFromsLibraryMini.Context.cs  # EF上下文
│   └── WinFromsLibraryMini.edmx # Entity Framework模型
└── packages/                     # NuGet包文件夹
```

### 主要文件说明

#### 表示层 (UI Layer)
- **LoginForm.cs**: 系统登录界面，包含邮箱、密码输入和验证码验证
- **BookManager.cs**: 主管理界面，包含菜单导航和用户控件容器
- **baseForm.cs**: 基础窗体类，提供通用的窗体功能
- **UserControls**: 模块化的用户控件，实现不同功能模块

#### 业务逻辑层 (BLL Layer)
- **LoginBLL.cs**: 处理用户登录验证逻辑
- **BookManagerBLL.cs**: 处理图书管理相关业务逻辑
- **ManagerBLL.cs**: 处理借阅记录管理业务逻辑
- **UsersBLL.cs**: 处理用户管理业务逻辑

#### 数据访问层 (DAL Layer)
- **LoginDAL.cs**: 用户登录数据访问，包含用户验证查询
- **BookManagerDAL.cs**: 图书数据访问，包含图书查询和借阅操作
- **ManagerDAL.cs**: 借阅记录数据访问，包含记录查询和归还操作
- **UsersDAL.cs**: 用户数据访问，包含用户信息管理

#### 数据模型层 (Models Layer)
- **User.cs**: 用户实体类，包含用户基本信息和导航属性
- **Book.cs**: 图书实体类，包含图书详细信息和库存管理
- **BorrowRecord.cs**: 借阅记录实体类，关联用户和图书
- **WinFromsLibraryMini.Context.cs**: Entity Framework数据库上下文

## 🚀 安装和运行

### 环境要求
- **操作系统**: Windows 7/8/10/11
- **开发环境**: .NET Framework 4.8
- **数据库**: SQL Server 2012 或更高版本
- **开发工具**: Visual Studio 2019/2022 (推荐)

### 安装步骤

1. **克隆项目**
   ```bash
   git clone https://github.com/yourusername/WinFromsLibraryMini.git
   cd WinFromsLibraryMini
   ```

2. **数据库配置**
   - 在SQL Server中创建数据库 `WinFromsLibraryMini`
   - 修改 `App.config` 中的连接字符串：
   ```xml
   <connectionStrings>
     <add name="WinFromsLibraryMiniEntities"
          connectionString="data source=你的服务器;initial catalog=WinFromsLibraryMini;user id=你的用户名;password=你的密码" />
   </connectionStrings>
   ```

3. **数据库初始化**
   ```sql
   -- 创建用户表
   CREATE TABLE Users (
       UserId int IDENTITY(1,1) PRIMARY KEY,
       Username nvarchar(50) NOT NULL,
       Password nvarchar(50) NOT NULL,
       Role nvarchar(20) NOT NULL,
       Email nvarchar(100) NOT NULL,
       Phone nvarchar(20)
   );

   -- 创建图书表
   CREATE TABLE Books (
       BookId int IDENTITY(1,1) PRIMARY KEY,
       Title nvarchar(100) NOT NULL,
       Author nvarchar(50),
       Publisher nvarchar(50),
       ISBN nvarchar(20),
       Price decimal(10,2),
       Stock int NOT NULL,
       Summary nvarchar(500)
   );

   -- 创建借阅记录表
   CREATE TABLE BorrowRecords (
       RecordId int IDENTITY(1,1) PRIMARY KEY,
       UserId int NOT NULL,
       BookId int NOT NULL,
       BorrowDate datetime NOT NULL,
       ReturnDate datetime,
       FOREIGN KEY (UserId) REFERENCES Users(UserId),
       FOREIGN KEY (BookId) REFERENCES Books(BookId)
   );
   ```

4. **还原NuGet包**
   ```bash
   nuget restore WinFromsLibraryMini.sln
   ```

5. **编译运行**
   - 使用Visual Studio打开 `WinFromsLibraryMini.sln`
   - 设置 `WinFromsLibraryMini` 为启动项目
   - 按 `F5` 运行项目

### 默认登录信息
```sql
-- 插入测试用户数据
INSERT INTO Users (Username, Password, Role, Email, Phone) VALUES
('admin', '123456', 'Admin', 'admin@example.com', '13800138000'),
('user1', '123456', 'User', 'user1@example.com', '13800138001');

-- 插入测试图书数据
INSERT INTO Books (Title, Author, Publisher, ISBN, Price, Stock, Summary) VALUES
('C#程序设计', '张三', '清华大学出版社', '978-7-302-12345-6', 45.00, 10, 'C#编程入门教程'),
('数据库原理', '李四', '机械工业出版社', '978-7-111-23456-7', 52.00, 8, '数据库设计与应用');
```

**默认登录账户**:
- 管理员: admin@example.com / 123456
- 普通用户: user1@example.com / 123456

## 💻 技术实现详解

### Entity Framework 数据访问
项目使用Entity Framework 6.2.0 Database First方式，通过.edmx文件管理数据模型：

```csharp
// DbContext 上下文类
public partial class WinFromsLibraryMiniEntities : DbContext
{
    public WinFromsLibraryMiniEntities() : base("name=WinFromsLibraryMiniEntities") { }

    public virtual DbSet<Book> Books { get; set; }
    public virtual DbSet<BorrowRecord> BorrowRecords { get; set; }
    public virtual DbSet<User> Users { get; set; }
}
```

### 核心业务逻辑实现

#### 图书借阅逻辑
```csharp
public int AddBook(int UserId, int BookId)
{
    try
    {
        // 创建借阅记录
        _BorrowRecord.UserId = UserId;
        _BorrowRecord.BookId = BookId;
        _BorrowRecord.BorrowDate = DateTime.Now;
        _BorrowRecord.ReturnDate = null;
        _DbContext.BorrowRecords.Add(_BorrowRecord);

        // 减少库存
        ReduceStock(BookId);

        // 保存更改
        _DbContext.SaveChanges();
        return 1;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        return 0;
    }
}
```

#### 验证码生成机制
```csharp
private void CodeVeriify()
{
    const string chars = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM0123456789";
    string code = new string(Enumerable.Repeat(chars, 4)
        .Select(s => s[random.Next(s.Length)]).ToArray());
    textBoxCode.Text = code;
}
```

### WinForms界面设计模式
- **基础窗体继承**: 所有窗体继承自baseForm，实现统一的界面风格
- **用户控件模块化**: 使用UserControl实现功能模块的独立开发和维护
- **数据绑定**: 使用DataGridView进行数据展示和交互

## 🛠️ 开发信息

### 开发工具和版本
- **IDE**: Visual Studio 2022 (v17.14.36109.1)
- **目标框架**: .NET Framework 4.8
- **项目模板**: Windows Forms App (.NET Framework)
- **版本控制**: Git

### 第三方依赖包
| 包名 | 版本 | 用途 | 许可证 |
|------|------|------|--------|
| EntityFramework | 6.2.0 | ORM数据访问框架 | Apache 2.0 |
| EntityFramework.zh-Hans | 6.2.0 | Entity Framework中文语言包 | Apache 2.0 |

### 系统要求
- **最低系统要求**: Windows 7 SP1
- **推荐系统**: Windows 10/11
- **内存要求**: 最少2GB RAM
- **磁盘空间**: 至少100MB可用空间
- **数据库**: SQL Server 2012 Express或更高版本

## 🔧 已知问题和改进建议

### 🔒 安全性改进
- [ ] **密码加密存储**: 当前密码明文存储，建议使用BCrypt或SHA256加密
- [ ] **SQL注入防护**: 虽然使用EF，但建议加强参数验证
- [ ] **输入验证**: 加强用户输入的验证和清理
- [ ] **会话管理**: 实现更安全的用户会话管理机制

```csharp
// 建议的密码加密实现
public string HashPassword(string password)
{
    return BCrypt.Net.BCrypt.HashPassword(password);
}

public bool VerifyPassword(string password, string hash)
{
    return BCrypt.Net.BCrypt.Verify(password, hash);
}
```

### 🏗️ 架构改进
- [ ] **依赖注入**: 引入IoC容器，如Unity或Autofac
- [ ] **异步编程**: 数据库操作改为异步模式，提升性能
- [ ] **日志记录**: 集成NLog或Serilog进行日志管理
- [ ] **配置管理**: 实现更灵活的配置管理模式

### 🧪 质量改进
- [ ] **单元测试**: 添加MSTest或NUnit单元测试
- [ ] **异常处理**: 完善全局异常处理机制
- [ ] **代码规范**: 遵循C#编码规范，使用StyleCop
- [ ] **性能优化**: 数据库查询优化和内存管理

### 🎨 用户体验改进
- [ ] **现代化UI**: 升级到WPF或使用现代UI库
- [ ] **响应式设计**: 支持不同分辨率和DPI设置
- [ ] **多语言支持**: 实现国际化和本地化
- [ ] **主题切换**: 支持深色/浅色主题切换

### 📱 功能扩展建议
- [ ] **高级搜索**: 实现多条件组合搜索功能
- [ ] **数据导出**: 支持Excel、PDF等格式导出
- [ ] **统计报表**: 添加借阅统计和图表展示
- [ ] **消息通知**: 实现逾期提醒和消息推送

## 📊 项目统计

- **代码行数**: 约2000行
- **文件数量**: 30+个源文件
- **开发周期**: 适合1-2个月的毕业设计项目
- **难度等级**: 中等（适合有C#基础的学习者）

## 📄 许可证

本项目采用 MIT 许可证 - 查看 [LICENSE](LICENSE) 文件了解详情。

## 🤝 贡献指南

欢迎提交 Issue 和 Pull Request 来改进这个项目！

### 贡献步骤
1. Fork 本项目
2. 创建特性分支 (`git checkout -b feature/AmazingFeature`)
3. 提交更改 (`git commit -m 'Add some AmazingFeature'`)
4. 推送到分支 (`git push origin feature/AmazingFeature`)
5. 开启 Pull Request

### 代码规范
- 遵循C#编码规范
- 添加必要的注释和文档
- 确保代码通过编译和测试

## 📞 联系方式

如有问题或建议，请通过以下方式联系：
- 📧 Email: your.email@example.com
- 🐛 Issues: [GitHub Issues](https://github.com/yourusername/WinFromsLibraryMini/issues)
- 💬 讨论: [GitHub Discussions](https://github.com/yourusername/WinFromsLibraryMini/discussions)

## 🙏 致谢

感谢所有为这个项目做出贡献的开发者和使用者！

## 📚 相关资源

- [C# 官方文档](https://docs.microsoft.com/zh-cn/dotnet/csharp/)
- [Entity Framework 6 文档](https://docs.microsoft.com/zh-cn/ef/ef6/)
- [Windows Forms 文档](https://docs.microsoft.com/zh-cn/dotnet/desktop/winforms/)
- [SQL Server 文档](https://docs.microsoft.com/zh-cn/sql/sql-server/)

---

⭐ 如果这个项目对您有帮助，请给它一个星标！

📝 **最后更新**: 2025年1月

🎯 **项目状态**: 活跃开发中