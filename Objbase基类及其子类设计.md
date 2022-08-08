ObjBase

id，modelPath， 模型  ，位置共同的属性 ；

共同的方法  创建物体的方法  移动  ，设置位置  销毁

ObjInfo

共同的基本信息，id，name，pos，res，m_type

PlayerObj继承Objectbase

有自己的PlayerInfor：

playerInfo继承Objinfo，有自己的属性：等级、血量、技能列表

OnCreate中添加UIPate   脚本中持有ui模型

Hostplayer继承PlayerObj

HostPlayer创建后添加player脚本 摇杆移动调用基类移动方法，技能释放调用脚本的技能释放方法

总结：数据持有模型  调用方法来控制人物进行一系列操作