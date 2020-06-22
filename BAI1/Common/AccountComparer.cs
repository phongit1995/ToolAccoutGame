using BAI1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI1.Common
{
    internal class AccountComparer : IEqualityComparer<Account>
    {
        // Token: 0x0600008B RID: 139 RVA: 0x00003FBC File Offset: 0x000021BC
        public int Compare(Account x, Account y)
        {
            bool flag = x == null && y == null;
            int result;
            if (flag)
            {
                result = 0;
            }
            else
            {
                bool flag2 = x == null;
                if (flag2)
                {
                    result = -1;
                }
                else
                {
                    bool flag3 = y == null;
                    if (flag3)
                    {
                        result = 1;
                    }
                    else
                    {
                        bool flag4 = x.Username.Equals(y.Username) && x.Password.Equals(y.Password);
                        if (flag4)
                        {
                            result = 0;
                        }
                        else
                        {
                            result = 1;
                        }
                    }
                }
            }
            return result;
        }

        // Token: 0x0600008C RID: 140 RVA: 0x0000402C File Offset: 0x0000222C
        public bool Equals(Account x, Account y)
        {
            return x.Username.Equals(y.Username) && x.Password.Equals(y.Password);
        }

        // Token: 0x0600008D RID: 141 RVA: 0x00004068 File Offset: 0x00002268
        public int GetHashCode(Account obj)
        {
            return obj.Username.GetHashCode() ^ obj.Password.GetHashCode();
        }
    }
}