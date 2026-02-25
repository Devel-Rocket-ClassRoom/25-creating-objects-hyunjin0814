using System;

class BankAccount
{
    private static int TotalAccounts;
    private static int StartNumber;

    private string AccountNumber;
    private string OwnerName;
    private int Balance;

    static BankAccount()
    {
        TotalAccounts = 0;
        StartNumber = 1001;
    }
    public BankAccount(string name, int amount)
    {
        AccountNumber = StartNumber.ToString();
        StartNumber++;
        TotalAccounts++;
        OwnerName = name;
        Balance = amount;

        Console.WriteLine($"[{AccountNumber}] {OwnerName} 계좌가 개설되었습니다.");
    }

    public void Deposit(int amount)
    {
        Balance += amount;
        Console.WriteLine($"[{AccountNumber}] {amount}원 입금 완료. 잔액: {Balance}원");
    }

    public void Withdraw(int amount)
    {
        if (Balance - amount < 0)
        {
            Console.WriteLine($"[{AccountNumber}] {amount}원 출금 실패. 잔액이 부족합니다.");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"[{AccountNumber}] {amount}원 출금 완료. 잔액: {Balance}원");
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine($"계좌번호: {AccountNumber}, 예금주: {OwnerName}, 잔액: {Balance}원");
    }

    public static void ShowTotalAccounts()
    {
        Console.WriteLine($"현재 총 계좌 수: {TotalAccounts}개");
    }
}