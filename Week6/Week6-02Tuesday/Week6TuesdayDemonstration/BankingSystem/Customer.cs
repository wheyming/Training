using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Customer
    {
        public string customer_id { get; private set; }
        public string customer_name { get; private set; }
        public string account_number { get; private set; }
        public double account_balance { get; set; }
        public string check_book_number { get; private set; }
        public bool loan_applied { get; set; }
        public Customer(string id, string name, string account_no, string check_bk_no)
        {
            customer_id = id;
            customer_name = name;
            account_number = account_no;
            account_balance = 0;
            check_book_number = check_bk_no;
            loan_applied = false;
        }

        public Customer(string id, string name, string account_no, string check_bk_no, double bal, bool loan_app)
        {
            customer_id = id;
            customer_name = name;
            account_number = account_no;
            account_balance = bal;
            check_book_number = check_bk_no;
            loan_applied = loan_app;
        }

        public override string ToString()
        {
            return customer_id + "_" + customer_name + "_" + account_number + "_" + account_balance + "_" + check_book_number + "_" + loan_applied;
        }
    }
}
