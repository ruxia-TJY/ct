# CT

[English](https://github.com/ruxia-TJY/CT/blob/master/README.md)


一系列在命令行使用的工具。

也许有其他更好工具，或者只是我对系统命令和工具的认识不够。我只是需要什么，便尝试做了。


## 使用方法

将程序添加到系统环境变量，请区分运行平台。

### Linux

确保gcc已经安装并在系统环境变量中。

`clone`仓库，运行`sh ./make.sh`编译，程序将会编译在bin目录下。
使用`sh ./make.sh clean`清除编译内容

### Windows

使用VS打开.sln文件进行编译。

或者将c#编译器`csc`添加到系统环境变量，运行`make.bat`文件。


## 列表

| 名称 | 编写语言 | 描述 | 支持平台 |
| :--: | :------: | :----------------------------------------: | :----: |
| now  |    c#    | 输出当前时间日期（公历，农历，干支，生肖） | Windows 7,10|
| p | c | 换行输出PATH变量 | Linux |
| q | bat | exit | Windows |

## 协议
代码和文件在本仓库的使用Apache协议。
