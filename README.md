# 设备监控仪表盘项目

该仓库用于简易温度监控上位机的需求、设计与实现管理。详细的软件需求规格说明书请参阅 [`docs/SoftwareRequirementsSpecification.md`](docs/SoftwareRequirementsSpecification.md)。

## 运行/构建

1. 使用 Visual Studio 2022 或更高版本打开根目录下的 `DeviceMonitor.sln`。
2. 将启动项目设置为 `DeviceMonitor.App`，目标框架需安装 .NET 6.0 (Windows)。
3. 编译并运行后即可看到 Windows Forms 图形化界面，用于串口连接、温度显示、数据记录与报警配置。

> 注：本项目包含串口访问与声音报警功能，运行时请确认 PC 具备可用串口以及音频输出设备。
