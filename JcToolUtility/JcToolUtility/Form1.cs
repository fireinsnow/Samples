using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;

namespace JcToolUtility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// C++起始时间刻度。
        /// </summary>
        public static readonly DateTime StartTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        private void btnShuTochuan_Click(object sender, EventArgs e)
        {
            //string ip = txtIpShuzi.ToString();
            //IPAddress ip = IPAddress.Parse(txtIpShuzi.Text.ToString());
            //txtIpchuan.Text= ip.ToString();
            long ipInt = long.Parse(txtIpShuzi.Text.Trim());
            StringBuilder sb = new StringBuilder();
            
           
           
            sb.Append(ipInt & 0xFF).Append(".");
            sb.Append((ipInt >> 8) & 0xFF).Append(".");
             sb.Append((ipInt >> 16) & 0xFF).Append(".");
            sb.Append((ipInt >> 24) & 0xFF);
            txtIpchuan.Text=  sb.ToString();

        }

        private void btnChuanToshuzi_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse(txtIpchuan.Text.ToString());

           txtIpShuzi.Text= BitConverter.ToInt32(ip.GetAddressBytes(), 0).ToString();
        }

        /// <summary>
        /// 数字转时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            int tm = int.Parse(txtShuzi.Text.Trim());

            dateTimePicker1.Value = StartTime.AddSeconds(tm ).ToLocalTime();// StartTime.AddSeconds(tm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtShuzi.Text =((int)(dateTimePicker1.Value.ToUniversalTime() - StartTime).TotalSeconds).ToString();// (int)(time.ToUniversalTime() - StartTime).TotalSeconds
        }

        /// <summary>
        /// 将C#时间转换为C++时间。
        /// </summary>
        /// <param name="time">时间。</param>
        /// <returns></returns>
        public static int GetTimeTick(DateTime time)
        {
            return (int)(time.ToUniversalTime() - StartTime).TotalSeconds;
        }

        /// <summary>
        /// 将C++时间转换为C#时间字符串。
        /// </summary>
        /// <param name="tick">时间刻度。</param>
        /// <returns></returns>
        public static string GetDateString(int tick)
        {
            if (tick <= 0) return null;

            DateTime time = StartTime.AddSeconds(tick);
            return time.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss");
        }

       
    }
}
