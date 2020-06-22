using BAI1.Common;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BAI1.Model
{
    public class Account : BaseViewModel, IComparable<Account>
    {
        // Token: 0x1700001C RID: 28
        // (get) Token: 0x06000068 RID: 104 RVA: 0x00003B76 File Offset: 0x00001D76
        // (set) Token: 0x06000069 RID: 105 RVA: 0x00003B7E File Offset: 0x00001D7E
        private string AccessToken { get; set; } = "";

        // Token: 0x1700001D RID: 29
        // (get) Token: 0x0600006A RID: 106 RVA: 0x00003B88 File Offset: 0x00001D88
        // (set) Token: 0x0600006B RID: 107 RVA: 0x00003BA0 File Offset: 0x00001DA0
        public string Mobile
        {
            get
            {
                return this.mobile;
            }
            set
            {
                this.mobile = value;
                this.RaiseProperChanged("Mobile");
            }
        }

        // Token: 0x1700001E RID: 30
        // (get) Token: 0x0600006C RID: 108 RVA: 0x00003BB8 File Offset: 0x00001DB8
        // (set) Token: 0x0600006D RID: 109 RVA: 0x00003BD0 File Offset: 0x00001DD0
        public string Telesafe
        {
            get
            {
                return this.telesafe;
            }
            set
            {
                this.telesafe = value;
                this.RaiseProperChanged("Telesafe");
            }
        }

        // Token: 0x1700001F RID: 31
        // (get) Token: 0x0600006E RID: 110 RVA: 0x00003BE8 File Offset: 0x00001DE8
        // (set) Token: 0x0600006F RID: 111 RVA: 0x00003C00 File Offset: 0x00001E00
        public int VipPoint
        {
            get
            {
                return this.vipPoint;
            }
            set
            {
                this.vipPoint = value;
                this.RaiseProperChanged("VipPoint");
            }
        }

        // Token: 0x17000020 RID: 32
        // (get) Token: 0x06000070 RID: 112 RVA: 0x00003C18 File Offset: 0x00001E18
        // (set) Token: 0x06000071 RID: 113 RVA: 0x00003C30 File Offset: 0x00001E30
        public int GoldBalance
        {
            get
            {
                return this.goldBalance;
            }
            set
            {
                this.goldBalance = value;
                this.RaiseProperChanged("GoldBalance");
            }
        }

        // Token: 0x17000021 RID: 33
        // (get) Token: 0x06000072 RID: 114 RVA: 0x00003C48 File Offset: 0x00001E48
        // (set) Token: 0x06000073 RID: 115 RVA: 0x00003C60 File Offset: 0x00001E60
        public int CoinBalance
        {
            get
            {
                return this.coinBalance;
            }
            set
            {
                this.coinBalance = value;
                this.RaiseProperChanged("CoinBalance");
            }
        }

        // Token: 0x17000022 RID: 34
        // (get) Token: 0x06000074 RID: 116 RVA: 0x00003C78 File Offset: 0x00001E78
        // (set) Token: 0x06000075 RID: 117 RVA: 0x00003C90 File Offset: 0x00001E90
        public int StockBalance
        {
            get
            {
                return this.stockBalance;
            }
            set
            {
                this.stockBalance = value;
                this.RaiseProperChanged("StockBalance");
            }
        }

        // Token: 0x17000023 RID: 35
        // (get) Token: 0x06000077 RID: 119 RVA: 0x00003D40 File Offset: 0x00001F40
        // (set) Token: 0x06000078 RID: 120 RVA: 0x00003D58 File Offset: 0x00001F58
        public long AccountId
        {
            get
            {
                return this.accountId;
            }
            set
            {
                this.accountId = value;
                this.RaiseProperChanged("AccountId");
            }
        }

        // Token: 0x17000024 RID: 36
        // (get) Token: 0x06000079 RID: 121 RVA: 0x00003D70 File Offset: 0x00001F70
        // (set) Token: 0x0600007A RID: 122 RVA: 0x00003D88 File Offset: 0x00001F88
        public long Index
        {
            get
            {
                return this.index;
            }
            set
            {
                this.index = value;
                this.RaiseProperChanged("Index");
            }
        }

        // Token: 0x17000025 RID: 37
        // (get) Token: 0x0600007B RID: 123 RVA: 0x00003DA0 File Offset: 0x00001FA0
        // (set) Token: 0x0600007C RID: 124 RVA: 0x00003DB8 File Offset: 0x00001FB8
        public bool IsChecked
        {
            get
            {
                return this.isChecked;
            }
            set
            {
                this.isChecked = value;
                this.RaiseProperChanged("IsChecked");
            }
        }

        // Token: 0x17000026 RID: 38
        // (get) Token: 0x0600007D RID: 125 RVA: 0x00003DD0 File Offset: 0x00001FD0
        // (set) Token: 0x0600007E RID: 126 RVA: 0x00003DE8 File Offset: 0x00001FE8
        public string Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
                this.RaiseProperChanged("Status");
            }
        }

        // Token: 0x17000027 RID: 39
        // (get) Token: 0x0600007F RID: 127 RVA: 0x00003E00 File Offset: 0x00002000
        // (set) Token: 0x06000080 RID: 128 RVA: 0x00003E18 File Offset: 0x00002018
        public string Foreground
        {
            get
            {
                return this.foreground;
            }
            set
            {
                this.foreground = value;
                this.RaiseProperChanged("Foreground");
            }
        }

        // Token: 0x17000028 RID: 40
        // (get) Token: 0x06000081 RID: 129 RVA: 0x00003E30 File Offset: 0x00002030
        // (set) Token: 0x06000082 RID: 130 RVA: 0x00003E48 File Offset: 0x00002048
        public string Proxy
        {
            get
            {
                return this.proxy;
            }
            set
            {
                this.proxy = value;
                this.RaiseProperChanged("Proxy");
            }
        }

        // Token: 0x17000029 RID: 41
        // (get) Token: 0x06000083 RID: 131 RVA: 0x00003E60 File Offset: 0x00002060
        // (set) Token: 0x06000084 RID: 132 RVA: 0x00003E78 File Offset: 0x00002078
        public string Nickname
        {
            get
            {
                return this.nickname;
            }
            set
            {
                this.nickname = value;
                this.RaiseProperChanged("Nickname");
            }
        }

        // Token: 0x1700002A RID: 42
        // (get) Token: 0x06000085 RID: 133 RVA: 0x00003E90 File Offset: 0x00002090
        // (set) Token: 0x06000086 RID: 134 RVA: 0x00003EA8 File Offset: 0x000020A8
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
                this.RaiseProperChanged("Password");
            }
        }

        // Token: 0x1700002B RID: 43
        // (get) Token: 0x06000087 RID: 135 RVA: 0x00003EC0 File Offset: 0x000020C0
        // (set) Token: 0x06000088 RID: 136 RVA: 0x00003ED8 File Offset: 0x000020D8
        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                this.username = value;
                this.RaiseProperChanged("Username");
            }
        }

        // Token: 0x06000089 RID: 137 RVA: 0x00003EF0 File Offset: 0x000020F0
        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}", new object[]
            {
                this.Username,
                this.Password,
                this.Nickname,
                this.VipPoint,
                this.GoldBalance,
                this.CoinBalance,
                this.Mobile,
                this.Telesafe,
                this.StockBalance
            });
        }

        public async Task<int> GetInfo(GameGate game)
        {   
            this.Status = "Đang Running";
            HttpClient client = new HttpClient();
            JObject js = new JObject();
            js["Md5Password"] = Utils.MD5(this.Password);
            js["Username"] = this.Username;
            js["Password"] = this.Password;
            var content = new StringContent(js.ToString(), Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage httpResponseMessage = await client.PostAsync(game.LoginApi, content);
                var exec = await httpResponseMessage.Content.ReadAsStringAsync();
                JObject data = JObject.Parse(exec);
               
                if ((int)data["c"] !=0)
                {
                    this.Status = "Sai Mật Khẩu";
                }
                else
                {
                    this.Status = "Thành Công";
                    this.AccessToken = data["m"].ToString();
                    dynamic jsd = JObject.Parse(data["d"].ToString());
                    this.Nickname = jsd.nickname;
                    this.GoldBalance = (int)jsd.goldBalance;
                    this.CoinBalance = (int)jsd.coinBalance;
                    this.VipPoint = (int)jsd.vipPoint;
                    this.Mobile = jsd.mobile;
                   
                }
                return 1;
            }
            catch (Exception e)
            {
                this.Status = e.ToString();
                return 1;
            }
            
        }
        public int CompareTo(Account other)
        {
            bool flag = this.Username.Equals(other.username) && this.Password.Equals(other.password);
            int result;
            if (flag)
            {
                result = 0;
            }
            else
            {
                result = 1;
            }
            return result;
        }
        public bool IsLoginSuccess = false;
        private string mobile = "";

        private string telesafe = "";

        private int vipPoint = 0;

        public int goldBalance = 0;
        public int coinBalance = 0;

        public int stockBalance = 0;

        private string password = StringUtils.GetRandomPassword();
        private string username = StringUtils.GetRandomUsername();
        private string nickname = "";

        private long accountId;


        private long index;

  
        private bool isChecked = false;

        private string status;

        // Token: 0x04000050 RID: 80
        private string foreground = "#000000";

        // Token: 0x04000051 RID: 81
        private string proxy = "";
    }
}
