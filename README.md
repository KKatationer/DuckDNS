# DuckDNS
Windows下注册Duck DNS程序

## 编译使用
使用VS2022打开sln文件，项目框架默认.net7.0，可以自行降至.net framework 4

## 使用方式
+ 第一步
先在官网<https://www.duckdns.org/>注册，添加Domain并获得Token

+ 第二步
将域名和Token填入App.config文件的相应项中

+ 第三步
双击exe程序，启动后检查info.log日志或在官网检查域名是否成功绑定IP

## 另外
**本程序不判断是否为公网私网IP**
