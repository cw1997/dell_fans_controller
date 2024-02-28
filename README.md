# dell_fans_controller | 戴尔服务器风扇转速控制工具

This is a tool for adjusting the fan speed of Dell servers. It operates by using the `ipmitool` command-line utility for Windows to adjust fan speeds. `ipmitool` controls the server through the IPMI features, which requires the IPMI over LAN feature to be enabled on the server. For detailed operation methods, please refer to this article: [Introduction to server BMC, IPMI and Dell server fan speed reduction method - Zhihu](https://zhuanlan.zhihu.com/p/157796567).

该工具用于调整戴尔服务器的风扇转速。它通过 Windows 的命令行工具 `ipmitool` 来调整风扇转速。`ipmitool` 通过服务器的 IPMI 功能进行控制，使用该工具前需确保服务器已启用 IPMI over LAN 功能。具体操作方法请参考此文章：[服务器的BMC，IPMI介绍以及Dell服务器风扇降速方法 - 知乎](https://zhuanlan.zhihu.com/p/157796567)。

## Latest Release Download Links | 最新版下载地址

### V1.0.2 (Added independent fan control @zzccchen | 添加独立风扇控制 @zzccchen)
[Download V1.0.2 | 下载 V1.0.2](https://github.com/zzccchen/dell_fans_controller/releases/download/v1.0.2/Dell_EMC_Fans_Controller_1.0.2.zip)

### V1.0.1 (@jiafeng5513)
[Download V1.0.1 | 下载 V1.0.1](https://github.com/jiafeng5513/dell_fans_controller/releases/download/V1.0.1/Dell_EMC_Fans_Controller_1.0.1.zip)

### V1.0.0 (@cw1997)
[Download V1.0.0 | 下载 V1.0.0](https://github.com/cw1997/dell_fans_controller/releases/download/v1.0.0/dell_fans_controller_v1.0.0.zip)

## Build Environment | 构建环境

To build the source code for this project, the following environment is required:

为了构建本项目的源代码，您需要具备以下环境：

- Visual Studio 2022 or higher | Visual Studio 2022 或更高版本
- Windows 10 or higher | Windows 10 或更高版本
- .NET Framework 4.5 or higher | .NET Framework 4.5 或更高版本

## Contributing | 贡献

Contributions to this project are welcome! If you have any suggestions or improvements, please submit an Issue or Pull Request.

欢迎对本项目进行贡献！如果您有任何建议或改进，请提交 Issue 或 Pull Request。
