# DbMnager-NF
数据库文档管理工具-NetFramework 版本
制作此工具的目的是方便管理数据文档，<br/>
可做到完全以数据库为主要（依赖于数据），一次更新，所有能访问的均是一致。<br/>
避免时间一长，数据库文档落差严重问题<br/>
提供的功能如下：<br/>
1.编辑表注释<br/>
2.编辑列注释<br/>
3.列表展示所有表与列<br/>

修改一下 Web.config -文件下的数据库连接对象即可使用，目前只实现了sqlserver，mysql，<br/>
sqlserverConnectionString:sqlserver数据库连接字符；
sqlserverDb:sqlserver数据库；
mysqlConnectionString:mysql数据库连接字符；
mysqlDb:mysql数据库；
