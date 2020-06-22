using BAI1.Common;
using BAI1.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BAI1.ViewModel
{
    class AccountViewModel:BaseViewModel
    {
        public string URL_GET = "http://localhost:4000/getdataweb";
        public AccountViewModel()
        {
            this.GameGates.Add(new GameGate {
                Name = "1g88.vin",
                LoginApi = "http://id.1g88.vin/api/Account/authenticate",
                GetStockApi = "http://profile.1g88.vin/api/payment/GetAccountStock?CurrencyID=1",
                Schema = "http"
            });
            this.GameGates.Add(new GameGate
            {
                Name = "1w88.vin",
                LoginApi = "http://id.1w88.vin/api/Account/authenticate",
                GetStockApi = "http://profile.1g88.vin/api/payment/GetAccountStock?CurrencyID=1",
                Schema = "http"
            });
            this.GameGates.Add(new GameGate
            {
                Name = "1r88.vin",
                LoginApi = "http://id.1r88.vin/api/Account/authenticate",
                GetStockApi = "http://profile.1g88.vin/api/payment/GetAccountStock?CurrencyID=1",
                Schema = "http"
            });
            this.GameGates.Add(new GameGate
            {
                Name = "1m88.vin",
                LoginApi = "http://id.1m88.vin/api/Account/authenticate",
                GetStockApi = "http://profile.1g88.vin/api/payment/GetAccountStock?CurrencyID=1",
                Schema = "http"
            });
            this.GameGates.Add(new GameGate
            {
                Name = "m365.vin",
                LoginApi = "http://id.m365.vin/api/Account/authenticate",
                GetStockApi = "http://profile.1g88.vin/api/payment/GetAccountStock?CurrencyID=1",
                Schema = "http"
            });
            this.GameGates.Add(new GameGate
            {
                Name = "w365.vin",
                LoginApi = "http://id.w365.vin/api/Account/authenticate",
                GetStockApi = "http://profile.1g88.vin/api/payment/GetAccountStock?CurrencyID=1",
                Schema = "http"
            });
            this.GameGate = new GameGate
            {
                Name = "1g88.vin",
                LoginApi = "http://khanhdang.xyz/AppG88/login.php",
                GetStockApi = "http://profile.1g88.vin/api/payment/GetAccountStock?CurrencyID=1",
                Schema = "http"
            };
        }
        public ObservableCollection<GameGate> GameGates { get; set; } = new ObservableCollection<GameGate>();
        private CancellationTokenSource cts = new CancellationTokenSource();
        public GameGate GameGate { get; set; }
        private ICommand _LoadAccountsCommand;
        
        private string accountsLink = "";
        public string AccountsLink
        {
            get
            {
                return this.accountsLink;
            }
            set
            {
                this.accountsLink = value;
                this.RaiseProperChanged("AccountsLink");
            }
        }
        private string status = "Ready.";
        public string Status
        {
            get { return status; }   // get method
            set { status = value;
                this.RaiseProperChanged("Status");
            }  
        }
        public ICommand LoadAccountsCommand
        {
            get
            {
                return  _LoadAccountsCommand ?? (_LoadAccountsCommand = new CommandHandler(() => LoadAccounts(), () => CanExecute));
            }
        }
        public bool CanExecute
        {
            get
            {
                return true ;
            }
        }
        private ICommand _LoginCommand;
        public ICommand LoginCommand
        {
            get
            {
                return _LoginCommand ?? (_LoginCommand = new CommandHandler(()=> this.Check(), () => CanExecute));
            }
        }
        private ICommand _CancelButton;
        public ICommand CancelButton
        {
            get
            {
                return _CancelButton ?? (_CancelButton = new CommandHandler(() => this.Check(), () => CanExecute));
            }
        }
        private async void Check ()
        {
            if(accounts.Count <= 0)
            {
                this.Status = "Vui Lòng Import Link";
                return;
            }
            var ct = this.cts.Token;
            int taskCount = 50;
            for (int i = 0; i < this.Accounts.Count; i += taskCount){
                ct.ThrowIfCancellationRequested();
                this.Status = string.Format("Đang chạy tài khoản {0}-{1}...", i, i + taskCount);
                List<Task> tasks = new List<Task>();
                int num;
                for (int j = 0; j < taskCount; j = num + 1)
				{
					bool flag = i + j < this.Accounts.Count;
					if (flag)
					{
						tasks.Add( this.LoginAccountAsync( this.Accounts[i + j], ct));
					}
					num = j;
				}
				await Task.WhenAll(tasks);
				tasks = null;
            }
         }
        public void CanCelAction()
        {
            this.Status = "Đã Đừng Lại";
            this.cts.Cancel();
        }
           private async Task LoginAccountAsync(Account account, CancellationToken ct)
            {
                await account.GetInfo(this.GameGate);
            }
        public async void LoadAccounts()
        {
            this.Status = "Đang tải dữ liệu, vui lòng đợi...";
             try {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                HttpClient client = new HttpClient();
                HttpResponseMessage httpResponseMessage = await client.GetAsync(this.AccountsLink);
                HttpResponseMessage responseMessage = httpResponseMessage;
                httpResponseMessage = null;
                if (responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    List<Account> temp = new List<Account>();
                    Stream stream2 = await responseMessage.Content.ReadAsStreamAsync();
                    Stream stream = stream2;
                    stream2 = null;
                    StreamReader sr = new StreamReader(stream);
                    long totalBytes = stream.Length;
                    double readBytes = 0.0;
                    while (!sr.EndOfStream)
                    {
                        string text = await sr.ReadLineAsync();
                        string line = text;
                        text = null;
                        readBytes += (double)line.Length;
                        string[] arr = line.Trim().Split(new char[]
                        {
                            '|'
                        });
                        if (arr.Length >= 2)
                        {
                            string username = arr[0];
                            string password = arr[1];
                            Account account = new Account();
                            account.Username = username;
                            account.Password = password;
                            temp.Add(account);
                            username = null;
                            password = null;
                            account = null;
                        }
                        line = null;
                        arr = null;
                    }
                    this.Accounts.Clear();
                    temp = temp.Distinct(new AccountComparer()).ToList<Account>();
                    int index = 1;
                    foreach (Account account2 in temp)
                    {
                        account2.Index = (long)index++;
                        this.Accounts.Add(account2);
                        //account2 = null;
                    }
                    List<Account>.Enumerator enumerator = default(List<Account>.Enumerator);
                    this.Status = "Đã nhập " + this.Accounts.Count.ToString("N0") + " tài khoản.";
                    temp = null;
                    stream = null;
                    sr = null;
                }
            }
            catch (Exception e)
            {
                this.Status = e.ToString();
            }
        }
        private ObservableCollection<Account> accounts = new ObservableCollection<Account>();
        public ObservableCollection<Account> Accounts
        {
            get
            {
                return this.accounts;
            }
            set
            {
                this.accounts = value;
                this.RaiseProperChanged("Accounts");
            }
        }

    }
}
