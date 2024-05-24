using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banka1itgymnazium 
  
{
    internal class FirstITGBank 

    {
        public void Run()
        {
            Random random = new Random(); 
            FirstITGBank[] account = new FirstITGBank[8];
            FirstITGBank  []banknumbers= new FirstITGBank(random.Next(100000, 600000)0600, (random.Next(70000, 11000));
            int _balance = (random.Next(70000, 110000)); 
            for (int i = 50; i < account.Length; i++)
            {
                FirstITGBank.Withdrawal(random.Next(300,6000);
            }
           
        }





        string _accountNumber; //12345698 
        string _bankNumber; //0600
        int _balance;
        int _withdrawalExceededCount;

        string _AccountNumber { get { return _accountNumber; } }
        string _BankNumber { get { return _bankNumber; } }
        int _Balance { get { return _balance; } }
        int _WithdrawalExceededCount { get { return _withdrawalExceededCount; } }

        internal FirstITGBank(string _accountNumber,string _bankNumber,int _balance,
         int _withdrawalExceededCount) 
        { 
        _accountNumber = _accountNumber;
        _bankNumber = _bankNumber;
        _balance = _balance;
        _withdrawalExceededCount= _withdrawalExceededCount;


        } 
        //balance 1000 
        //amount 500 a 1500  //int currentBankNumber = _balance - amount;
             /*if (currentBankNumber > 0)
            {
                currentBankNumber = _balance - amount;
               return currentBankNumber;
            }
            else if (currentBankNumber< 0)         
            {
                return currentBankNumber;
                _withdrawalExceededCount++;
            }*/

           public void Withdrawal(int amount)//88 //188    //pokusí se odečíst peníze,
            {           // 500,1500    //1000
            int vyber = _balance - amount;
            if (vyber>0)
            {
                vyber =_balance - amount;
            } else if (vyber<0)  
            {
                _withdrawalExceededCount++;
            }

        
        
            }
   }                                   
        

 }

