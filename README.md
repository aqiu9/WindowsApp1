# WindowsApp1
vb.net编写，简单的信号机点灯、进站模拟程序

# Draft Of Requirements
line指信号机右侧一条线
me指我们研究的信号机
a指左侧共线距离较近一个开关（信号机）
b指左侧共线最远端，线路终点一个开关（信号机）
c指左侧不共线一个开关（信号机）
“取消”指小软件界面下方取消按钮
“人解”指小软件界面下方人解按钮


无操作（其他操作结束后） 单红 
 LineShape_red1, LineShape_red2,LineShape_red3, LineShape_red4_1, LineShape_red4_2, LineShape_red4_3, LineShape_red4_4, LineShape_red6_1, LineShape_red6_2, LineShape_red6_3, LineShape_red6_4, LineShape_red6_5, LineShape_red6_6,  LineShape_red8, LineShape_red9
   
点亮顺序为XJZ220—RD1—DJ5-6—LXJ41-43—HBⅠ1-Ⅰ3—LXJ63-61—RD3—XJF220

me→a    单黄  
 LineShape_red1, LineShape_red2，LineShape_red3, LineShape_yellow4, LineShape_yellow5_1, LineShape_yellow5_2, LineShape_yellow6, LineShape_yellow7, LineShape_yellow8_1, LineShape_yellow8_2, LineShape_yellow8_3, LineShape_yellow9_1, LineShape_yellow9_2, LineShape_yellow9_3, LineShape_yellow9_4, LineShape_yellow9_5, LineShape_red8, LineShape_red9

点亮顺序为XJZ220—RD1—DJ5-6—LXJ41-42—ZXJ81-82—TXJ21-23—LUXJ21-23—UBⅠ1-Ⅰ3—LXJ62-61—RD3—XJF220

me→b    单绿
 LineShape_red1,LineShape_red2,LineShape_red3,LineShape_yellow4,LineShape_yellow5_1,LineShape_green6_1,LineShape_green6_2,LineShape_green6_3,LineShape_yellow7_1,LineShape_yellow7_2,LineShape_yellow7_3,LineShape_yellow7_4,LineShape_yellow9_5,LineShape_red8,LineShape_red9

点亮顺序为XJZ220—RD1—DJ5-6—LXJ41-42—ZXJ81-82—TXJ21-22—LBⅠ1-Ⅰ3—LXJ62-61—RD3—XJF220

me→c    双黄
先亮一个单黄：
 LineShape_red1, LineShape_red2，LineShape_red3, LineShape_yellow4, LineShape_yellow5_1, LineShape_yellow5_2, LineShape_yellow6, LineShape_yellow7, LineShape_yellow8_1, LineShape_yellow8_2, LineShape_yellow8_3, LineShape_yellow9_1, LineShape_yellow9_2, LineShape_yellow9_3, LineShape_yellow9_4, LineShape_yellow9_5, LineShape_red8, LineShape_red9,
再接着，
LineShape_dy1,LineShape_dy2,LineShape_dy3,LineShape_dy4,LineShape_dy5,LineShape_dy6_1,LineShape_dy6_2,LineShape_dy6_3,LineShape_dy7_1,LineShape_dy7_2,LineShape_dy7_3

点亮顺序为XJZ220—RD2—2DJ5-6—LXJ71-72—ZXJ71-73—TXJ11-13—2UBⅠ1-Ⅰ3—LXJ62-61—RD3—XJF220
XJZ220—RD2—DJ5-6—LXJ41-42—ZXJ81-83—2DJ21-22—LUXJ21-23—UBⅠ1-Ⅰ3—LXJ62-61—RD3—XJF220

上述操作恢复操作为：取消→me     恢复为单红


对line操作设置故障→me    红白（ppt为红蓝）
Role.Null的单红 +  蓝
"LineShape_red1", "LineShape_red2", "LineShape_red3", "LineShape_red4_1", "LineShape_red4_2", "LineShape_red4_3", "LineShape_red4_4", "LineShape_red6_1", "LineShape_red6_2", "LineShape_red6_3", "LineShape_red6_4", "LineShape_red6_5", "LineShape_red6_6", "LineShape_red8", "LineShape_red9",
蓝
"LineShape_blue4_1", "LineShape_blue4_2", "LineShape_blue5_1", "LineShape_blue5_2", "LineShape_blue5_3", "LineShape_blue6_0", "LineShape_blue6_1", "LineShape_blue6_2", "LineShape_blue6_3", "LineShape_blue6_4", "LineShape_blue7_1", "LineShape_blue7_2", "LineShape_red8", "LineShape_red9"


点亮顺序为XJZ220—RD1—DJ5-6—LXJ41-43—HBⅠ1-Ⅰ3—LXJ63-61—RD3—XJF220
XJZ220—RD2—2DJ5-6—LXJ71-72—YXJ71-72—YBBⅠ1-Ⅰ3—YXJ62-61—LXJ63-61—RD3—XJF220
恢复操作为 人解→me 恢复为单红

# 各种截图留念
![847e59dc1a46291949ed2a4a8094946](https://user-images.githubusercontent.com/51012896/168103473-14a8c989-ad50-4ee3-a7b1-1cefdc53eeb7.jpg)

![image_217](https://user-images.githubusercontent.com/51012896/168103828-ffd4d3b9-a96d-43bb-bdf1-290d4daea285.png)
![image_218](https://user-images.githubusercontent.com/51012896/168103834-a544cba2-d54f-4d10-a474-2e26fd279a74.png)
![image_219](https://user-images.githubusercontent.com/51012896/168103837-fa8a88c1-fb4d-42de-b0bc-968086b73afd.png)
![image_220](https://user-images.githubusercontent.com/51012896/168103844-ce446a76-37bc-436e-9f70-2e1803909a56.png)
![image_221](https://user-images.githubusercontent.com/51012896/168103848-fef0239d-6b41-453e-bca3-b0d4b5a11bfc.png)

![image_222](https://user-images.githubusercontent.com/51012896/168103960-0dd4ab5a-3527-49b2-b8ce-23889ba28412.png)
![image_223](https://user-images.githubusercontent.com/51012896/168103972-54c56fbe-13e8-4732-95f9-88e2c5d24662.png)


# 演示（画质已加密）
https://user-images.githubusercontent.com/51012896/168104739-f933ad4a-e2a4-43d7-927e-db762d63c9ab.mp4

![image_224](https://user-images.githubusercontent.com/51012896/168105381-6b6b5749-d726-49fa-bcdf-7b1b3b5e98bd.png)
![image_225](https://user-images.githubusercontent.com/51012896/168105392-a154c920-6f50-441c-8262-e7675b4cc106.png)
![image_226](https://user-images.githubusercontent.com/51012896/168105397-3f211cd1-0b4e-42df-91ca-582cda509ab2.png)
![image_227](https://user-images.githubusercontent.com/51012896/168105405-48817d9a-fafc-429b-8acf-943606a032df.png)

