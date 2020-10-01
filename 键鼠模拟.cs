using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;

namespace 测试_控制台
{

    class Program
    {
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);  //发送按键
        [DllImport("user32.dll")]
        public static extern int SetCursorPos(int x, int y);   //移动鼠标
        [DllImport("User32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);   //寻找窗口
        static IntPtr PW = new IntPtr(0);  //如果没找到,则返回0
        [DllImport("user32.dll")]
        public static extern IntPtr SetForegroundWindow(IntPtr hw);    //激活窗口
        [DllImport("user32.dll")]
        public static extern int mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);    //移动鼠标
        #region
        const int MOUSEEVENTF_MOVE = 0x0001;        //移动鼠标 
        const int MOUSEEVENTF_LEFTDOWN = 0x0002;        //模拟鼠标左键按下 
        const int MOUSEEVENTF_LEFTUP = 0x0004;        //模拟鼠标左键抬起 
        const int MOUSEEVENTF_RIGHTDOWN = 0x0008;        //模拟鼠标右键按下 
        const int MOUSEEVENTF_RIGHTUP = 0x0010;        //模拟鼠标右键抬起 
        const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;        //模拟鼠标中键按下 
        const int MOUSEEVENTF_MIDDLEUP = 0x0040;        //模拟鼠标中键抬起 
        const int MOUSEEVENTF_ABSOLUTE = 0x8000;        //标示是否采用绝对坐标 
        const int MOUSEEVENTF_WHEEL = 0x0800;        //模拟鼠标滚轮滚动操作，必须配合dwData参数
        #endregion

        public static void Click_Mouse_Left() //单击左键
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
        public static void Click_Mouse_Right() //单击右键
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
        }
        #region
        //字母与数字键
        const byte a = 65;
        const byte b = 66;
        const byte c = 67;
        const byte d = 68;
        const byte e = 69;
        const byte f = 70;
        const byte g = 71;
        const byte h = 72;
        const byte i = 73;
        const byte j = 74;
        const byte k = 75;
        const byte l = 76;
        const byte m = 77;
        const byte n = 78;
        const byte o = 79;
        const byte p = 80;
        const byte q = 81;
        const byte r = 82;
        const byte s = 83;
        const byte t = 84;
        const byte u = 85;
        const byte v = 86;
        const byte w = 87;
        const byte x = 88;
        const byte y = 89;
        const byte z = 90;

        //数字键盘(字母上面那行)
        const byte key_num_0 = 96;
        const byte key_num_1 = 97;
        const byte key_num_2 = 98;
        const byte key_num_3 = 99;
        const byte key_num_4 = 100;
        const byte key_num_5 = 101;
        const byte key_num_6 = 102;
        const byte key_num_7 = 103;
        const byte key_num_8 = 104;
        const byte key_num_9 = 105;
        //F1-F12
        const byte F1 = 112;
        const byte F2 = 113;
        const byte F3 = 114;
        const byte F4 = 115;
        const byte F5 = 116;
        const byte F6 = 117;
        const byte F7 = 118;
        const byte F8 = 119;
        const byte F9 = 120;
        const byte F10 = 121;
        const byte F11 = 122;
        const byte F12 = 123;
        //右边数字键盘上的键
        //乘除加减等等
        const byte 乘 = 106;
        const byte 加 = 107;
        const byte Enter = 108;
        const byte 减 = 109;
        const byte 除 = 110;
        const byte 点 = 111;
        //小键盘数字
        const byte key_0 = 48;
        const byte key_1 = 49;
        const byte key_2 = 50;
        const byte key_3 = 51;
        const byte key_4 = 52;
        const byte key_5 = 53;
        const byte key_6 = 54;
        const byte key_7 = 55;
        const byte key_8 = 56;
        const byte key_9 = 57;
        //控制键   //有部分字符需要按下shift来输入
        const byte BackSpace = 8;
        const byte Tab = 9;
        const byte Clear = 12;
        const byte Enter_主键盘 = 13;
        const byte Shift = 16;
        const byte Control = 17;    //ctrl键
        const byte Alt = 18;
        const byte CapeLock = 20;
        const byte Esc = 27;
        const byte Spacebar = 32;
        const byte PageUp = 33;
        const byte PageDown = 34;
        const byte End = 35;
        const byte Home = 36;
        const byte LeftArrow = 37;
        const byte UpArrow = 38;
        const byte RightArrow = 39;
        const byte Insert = 40;
        const byte Delete = 46;
        const byte NumLock = 144;
        const byte 分号 = 186;
        const byte 等号 = 187;
        const byte 逗号 = 188;
        const byte 下划线号 = 189;
        const byte 大于号 = 190;
        const byte 问号 = 191;
        const byte 波浪号 = 192;
        const byte 左中括号 = 219;
        const byte 竖线号 = 220;
        const byte 右中括号 = 221;
        const byte 单引号 = 222;
        #endregion
        #region
        public static void letter_a()
        {
            Thread.Sleep(200);
            keybd_event(a, 0, 0, 0);
            keybd_event(a, 0, 2, 0);
        }
        public static void letter_b()
        {
            Thread.Sleep(200);
            keybd_event(b, 0, 0, 0);
            keybd_event(b, 0, 2, 0);
        }
        public static void letter_c()
        {
            Thread.Sleep(200);
            keybd_event(c, 0, 0, 0);
            keybd_event(c, 0, 2, 0);
        }
        public static void letter_d()
        {
            Thread.Sleep(200);
            keybd_event(d, 0, 0, 0);
            keybd_event(d, 0, 2, 0);
        }
        public static void letter_e()
        {
            Thread.Sleep(200);
            keybd_event(e, 0, 0, 0);
            keybd_event(e, 0, 2, 0);
        }
        public static void letter_f()
        {
            Thread.Sleep(200);
            keybd_event(f, 0, 0, 0);
            keybd_event(f, 0, 2, 0);
        }
        public static void letter_g()
        {
            Thread.Sleep(200);
            keybd_event(g, 0, 0, 0);
            keybd_event(g, 0, 2, 0);
        }
        public static void letter_h()
        {
            Thread.Sleep(200);
            keybd_event(h, 0, 0, 0);
            keybd_event(h, 0, 2, 0);
        }
        public static void letter_i()
        {
            Thread.Sleep(200);
            keybd_event(i, 0, 0, 0);
            keybd_event(i, 0, 2, 0);
        }
        public static void letter_j()
        {
            Thread.Sleep(200);
            keybd_event(j, 0, 0, 0);
            keybd_event(j, 0, 2, 0);
        }
        public static void letter_k()
        {
            Thread.Sleep(200);
            keybd_event(k, 0, 0, 0);
            keybd_event(k, 0, 2, 0);
        }
        public static void letter_l()
        {
            Thread.Sleep(200);
            keybd_event(l, 0, 0, 0);
            keybd_event(l, 0, 2, 0);
        }
        public static void letter_m()
        {
            Thread.Sleep(200);
            keybd_event(m, 0, 0, 0);
            keybd_event(m, 0, 2, 0);
        }
        public static void letter_n()
        {
            Thread.Sleep(200);
            keybd_event(n, 0, 0, 0);
            keybd_event(n, 0, 2, 0);
        }
        public static void letter_o()
        {
            Thread.Sleep(200);
            keybd_event(o, 0, 0, 0);
            keybd_event(o, 0, 2, 0);
        }
        public static void letter_p()
        {
            Thread.Sleep(200);
            keybd_event(p, 0, 0, 0);
            keybd_event(p, 0, 2, 0);
        }
        public static void letter_q()
        {
            Thread.Sleep(200);
            keybd_event(q, 0, 0, 0);
            keybd_event(q, 0, 2, 0);
        }
        public static void letter_r()
        {
            Thread.Sleep(200);
            keybd_event(r, 0, 0, 0);
            keybd_event(r, 0, 2, 0);
        }
        public static void letter_s()
        {
            Thread.Sleep(200);
            keybd_event(s, 0, 0, 0);
            keybd_event(s, 0, 2, 0);
        }
        public static void letter_t()
        {
            Thread.Sleep(200);
            keybd_event(t, 0, 0, 0);
            keybd_event(t, 0, 2, 0);
        }
        public static void letter_u()
        {
            Thread.Sleep(200);
            keybd_event(u, 0, 0, 0);
            keybd_event(u, 0, 2, 0);
        }
        public static void letter_v()
        {
            Thread.Sleep(200);
            keybd_event(v, 0, 0, 0);
            keybd_event(v, 0, 2, 0);
        }
        public static void letter_w()
        {
            Thread.Sleep(200);
            keybd_event(w, 0, 0, 0);
            keybd_event(w, 0, 2, 0);
        }
        public static void letter_x()
        {
            Thread.Sleep(200);
            keybd_event(x, 0, 0, 0);
            keybd_event(x, 0, 2, 0);
        }
        public static void letter_y()
        {
            Thread.Sleep(200);
            keybd_event(y, 0, 0, 0);
            keybd_event(y, 0, 2, 0);
        }
        public static void letter_z()
        {
            Thread.Sleep(200);
            keybd_event(z, 0, 0, 0);
            keybd_event(z, 0, 2, 0);
        }
        public static void letter_space()
        {
            Thread.Sleep(200);
            keybd_event(Spacebar, 0, 0, 0);
            keybd_event(Spacebar, 0, 2, 0);
        }
        public static void letter_enter()
        {
            Thread.Sleep(200);
            keybd_event(Enter, 0, 0, 0);
            keybd_event(Enter, 0, 2, 0);
        }
        public static void letter_0()
        {
            Thread.Sleep(200);
            keybd_event(key_0, 0, 0, 0);
            keybd_event(key_0, 0, 2, 0);
        }
        public static void letter_1()
        {
            Thread.Sleep(200);
            keybd_event(key_1, 0, 0, 0);
            keybd_event(key_1, 0, 2, 0);
        }
        public static void letter_2()
        {
            Thread.Sleep(200);
            keybd_event(key_2, 0, 0, 0);
            keybd_event(key_2, 0, 2, 0);
        }
        public static void letter_3()
        {
            Thread.Sleep(200);
            keybd_event(key_3, 0, 0, 0);
            keybd_event(key_3, 0, 2, 0);
        }
        public static void letter_4()
        {
            Thread.Sleep(200);
            keybd_event(key_4, 0, 0, 0);
            keybd_event(key_4, 0, 2, 0);
        }
        public static void letter_5()
        {
            Thread.Sleep(200);
            keybd_event(key_5, 0, 0, 0);
            keybd_event(key_5, 0, 2, 0);
        }
        public static void letter_6()
        {
            Thread.Sleep(200);
            keybd_event(key_6, 0, 0, 0);
            keybd_event(key_6, 0, 2, 0);
        }
        public static void letter_7()
        {
            Thread.Sleep(200);
            keybd_event(key_7, 0, 0, 0);
            keybd_event(key_7, 0, 2, 0);
        }
        public static void letter_8()
        {
            Thread.Sleep(200);
            keybd_event(key_8, 0, 0, 0);
            keybd_event(key_8, 0, 2, 0);
        }
        public static void letter_9()
        {
            Thread.Sleep(200);
            keybd_event(key_9, 0, 0, 0);
            keybd_event(key_9, 0, 2, 0);
        }
        public static void letter_分号()
        {
            Thread.Sleep(200);
            keybd_event(分号, 0, 0, 0);
            keybd_event(分号, 0, 2, 0);
        }
        public static void letter_单引号()
        {
            Thread.Sleep(200);
            keybd_event(单引号, 0, 0, 0);
            keybd_event(单引号, 0, 2, 0);
        }
        public static void letter_右中括号()
        {
            Thread.Sleep(200);
            keybd_event(右中括号, 0, 0, 0);
            keybd_event(右中括号, 0, 2, 0);
        }
        public static void letter_竖线号()
        {
            Thread.Sleep(200);
            keybd_event(竖线号, 0, 0, 0);
            keybd_event(竖线号, 0, 2, 0);
        }
        public static void letter_波浪号()
        {
            Thread.Sleep(200);
            keybd_event(波浪号, 0, 0, 0);
            keybd_event(波浪号, 0, 2, 0);
        }
        public static void letter_问号()
        {
            Thread.Sleep(200);
            keybd_event(问号, 0, 0, 0);
            keybd_event(问号, 0, 2, 0);
        }
        public static void letter_大于号()
        {
            Thread.Sleep(200);
            keybd_event(大于号, 0, 0, 0);
            keybd_event(大于号, 0, 2, 0);
        }
        public static void letter_下划线号()
        {
            Thread.Sleep(200);
            keybd_event(下划线号, 0, 0, 0);
            keybd_event(下划线号, 0, 2, 0);
        }
        public static void letter_逗号()
        {
            Thread.Sleep(200);
            keybd_event(逗号, 0, 0, 0);
            keybd_event(逗号, 0, 2, 0);
        }
        public static void letter_等号()
        {
            Thread.Sleep(200);
            keybd_event(等号, 0, 0, 0);
            keybd_event(等号, 0, 2, 0);
        }
        public static void letter_NumLock()
        {
            Thread.Sleep(200);
            keybd_event(NumLock, 0, 0, 0);
            keybd_event(NumLock, 0, 2, 0);
        }
        public static void letter_Delete()
        {
            Thread.Sleep(200);
            keybd_event(Delete, 0, 0, 0);
            keybd_event(Delete, 0, 2, 0);
        }
        public static void letter_Insert()
        {
            Thread.Sleep(200);
            keybd_event(Insert, 0, 0, 0);
            keybd_event(Insert, 0, 2, 0);
        }
        public static void letter_RightArrow()
        {
            Thread.Sleep(200);
            keybd_event(RightArrow, 0, 0, 0);
            keybd_event(RightArrow, 0, 2, 0);
        }
        public static void letter_UpArrow()
        {
            Thread.Sleep(200);
            keybd_event(UpArrow, 0, 0, 0);
            keybd_event(UpArrow, 0, 2, 0);
        }
        public static void letter_LeftArrow()
        {
            Thread.Sleep(200);
            keybd_event(LeftArrow, 0, 0, 0);
            keybd_event(LeftArrow, 0, 2, 0);
        }
        public static void letter_Home()
        {
            Thread.Sleep(200);
            keybd_event(Home, 0, 0, 0);
            keybd_event(Home, 0, 2, 0);
        }
        public static void letter_End()
        {
            Thread.Sleep(200);
            keybd_event(End, 0, 0, 0);
            keybd_event(End, 0, 2, 0);
        }
        public static void letter_PageDown()
        {
            Thread.Sleep(200);
            keybd_event(PageDown, 0, 0, 0);
            keybd_event(PageDown, 0, 2, 0);
        }
        public static void letter_PageUp()
        {
            Thread.Sleep(200);
            keybd_event(PageUp, 0, 0, 0);
            keybd_event(PageUp, 0, 2, 0);
        }
        public static void letter_Spacebar()
        {
            Thread.Sleep(200);
            keybd_event(Spacebar, 0, 0, 0);
            keybd_event(Spacebar, 0, 2, 0);
        }
        public static void letter_Esc()
        {
            Thread.Sleep(200);
            keybd_event(Esc, 0, 0, 0);
            keybd_event(Esc, 0, 2, 0);
        }
        public static void letter_CapeLock()
        {
            Thread.Sleep(200);
            keybd_event(CapeLock, 0, 0, 0);
            keybd_event(CapeLock, 0, 2, 0);
        }
        public static void letter_Alt()
        {
            Thread.Sleep(200);
            keybd_event(Alt, 0, 0, 0);
            keybd_event(Alt, 0, 2, 0);
        }
        public static void letter_Control()
        {
            Thread.Sleep(200);
            keybd_event(Control, 0, 0, 0);
            keybd_event(Control, 0, 2, 0);
        }
        public static void letter_Shift()
        {
            Thread.Sleep(200);
            keybd_event(Shift, 0, 0, 0);
            keybd_event(Shift, 0, 2, 0);
        }
        public static void letter_Enter_主键盘()
        {
            Thread.Sleep(200);
            keybd_event(Enter_主键盘, 0, 0, 0);
            keybd_event(Enter_主键盘, 0, 2, 0);
        }
        public static void letter_Clear()
        {
            Thread.Sleep(200);
            keybd_event(Clear, 0, 0, 0);
            keybd_event(Clear, 0, 2, 0);
        }
        public static void letter_Tab()
        {
            Thread.Sleep(200);
            keybd_event(Tab, 0, 0, 0);
            keybd_event(Tab, 0, 2, 0);
        }
        public static void letter_字母键盘_9()
        {
            Thread.Sleep(200);
            keybd_event(key_num_9, 0, 0, 0);
            keybd_event(key_num_9, 0, 2, 0);
        }
        public static void letter_字母键盘_8()
        {
            Thread.Sleep(200);
            keybd_event(key_num_8, 0, 0, 0);
            keybd_event(key_num_8, 0, 2, 0);
        }
        public static void letter_字母键盘_7()
        {
            Thread.Sleep(200);
            keybd_event(key_num_7, 0, 0, 0);
            keybd_event(key_num_7, 0, 2, 0);
        }
        public static void letter_字母键盘_6()
        {
            Thread.Sleep(200);
            keybd_event(key_num_6, 0, 0, 0);
            keybd_event(key_num_6, 0, 2, 0);
        }
        public static void letter_字母键盘_5()
        {
            Thread.Sleep(200);
            keybd_event(key_num_5, 0, 0, 0);
            keybd_event(key_num_5, 0, 2, 0);
        }
        public static void letter_字母键盘_4()
        {
            Thread.Sleep(200);
            keybd_event(key_num_4, 0, 0, 0);
            keybd_event(key_num_4, 0, 2, 0);
        }
        public static void letter_字母键盘_3()
        {
            Thread.Sleep(200);
            keybd_event(key_num_3, 0, 0, 0);
            keybd_event(key_num_3, 0, 2, 0);
        }
        public static void letter_字母键盘_2()
        {
            Thread.Sleep(200);
            keybd_event(key_num_2, 0, 0, 0);
            keybd_event(key_num_2, 0, 2, 0);
        }
        public static void letter_字母键盘_1()
        {
            Thread.Sleep(200);
            keybd_event(key_num_1, 0, 0, 0);
            keybd_event(key_num_1, 0, 2, 0);
        }
        public static void letter_字母键盘_0()
        {
            Thread.Sleep(200);
            keybd_event(key_num_0, 0, 0, 0);
            keybd_event(key_num_0, 0, 2, 0);
        }
        public static void letter_点()
        {
            Thread.Sleep(200);
            keybd_event(点, 0, 0, 0);
            keybd_event(点, 0, 2, 0);
        }
        public static void letter_减()
        {
            Thread.Sleep(200);
            keybd_event(减, 0, 0, 0);
            keybd_event(减, 0, 2, 0);
        }
        public static void letter_除()
        {
            Thread.Sleep(200);
            keybd_event(除, 0, 0, 0);
            keybd_event(除, 0, 2, 0);
        }
        public static void letter_加()
        {
            Thread.Sleep(200);
            keybd_event(加, 0, 0, 0);
            keybd_event(加, 0, 2, 0);
        }
        public static void letter_乘()
        {
            Thread.Sleep(200);
            keybd_event(乘, 0, 0, 0);
            keybd_event(乘, 0, 2, 0);
        }
        public static void letter_Enter()
        {
            Thread.Sleep(200);
            keybd_event(Enter, 0, 0, 0);
            keybd_event(Enter, 0, 2, 0);
        }
        public static void letter_F12()
        {
            Thread.Sleep(200);
            keybd_event(F12, 0, 0, 0);
            keybd_event(F12, 0, 2, 0);
        }
        public static void letter_F11()
        {
            Thread.Sleep(200);
            keybd_event(F11, 0, 0, 0);
            keybd_event(F11, 0, 2, 0);
        }
        public static void letter_F10()
        {
            Thread.Sleep(200);
            keybd_event(F10, 0, 0, 0);
            keybd_event(F10, 0, 2, 0);
        }
        public static void letter_F9()
        {
            Thread.Sleep(200);
            keybd_event(F9, 0, 0, 0);
            keybd_event(F9, 0, 2, 0);
        }
        public static void letter_F8()
        {
            Thread.Sleep(200);
            keybd_event(F8, 0, 0, 0);
            keybd_event(F8, 0, 2, 0);
        }
        public static void letter_F7()
        {
            Thread.Sleep(200);
            keybd_event(F7, 0, 0, 0);
            keybd_event(F7, 0, 2, 0);
        }
        public static void letter_F6()
        {
            Thread.Sleep(200);
            keybd_event(F6, 0, 0, 0);
            keybd_event(F6, 0, 2, 0);
        }
        public static void letter_F5()
        {
            Thread.Sleep(200);
            keybd_event(F5, 0, 0, 0);
            keybd_event(F5, 0, 2, 0);
        }
        public static void letter_F4()
        {
            Thread.Sleep(200);
            keybd_event(F4, 0, 0, 0);
            keybd_event(F4, 0, 2, 0);
        }
        public static void letter_F3()
        {
            Thread.Sleep(200);
            keybd_event(F3, 0, 0, 0);
            keybd_event(F3, 0, 2, 0);
        }
        public static void letter_F2()
        {
            Thread.Sleep(200);
            keybd_event(F2, 0, 0, 0);
            keybd_event(F2, 0, 2, 0);
        }
        public static void letter_F1()
        {
            Thread.Sleep(200);
            keybd_event(F1, 0, 0, 0);
            keybd_event(F1, 0, 2, 0);
        }
        #endregion



        static void Main(string[] args)
        {
            PW = FindWindow("窗口类名", "窗口名,可使用vs工具菜单提供的Spy++查看"); //获取窗口句柄
            SetForegroundWindow(PW);    //将窗口置顶
            SetCursorPos(783, 942);     //移动鼠标
            letter_a();     //输入一次a键
            //如果要使用大写,请按下shift键或者打开大写锁定,打开大写锁定容易出错,建议只使用shift
            //如:
            keybd_event(Shift, 0, 0, 0);
            letter_a();         //输入一次a键
            keybd_event(Shift, 0, 2, 0);
            //点击鼠标
            Click_Mouse_Left();     //点击鼠标左键
            Click_Mouse_Right();    //点击鼠标右键

            //有一些键要按下shift才能输入比如双引号,如:
            keybd_event(Shift, 0, 0, 0);
            letter_单引号();         //输入一次a键
            keybd_event(Shift, 0, 2, 0);
        }
    }
}
