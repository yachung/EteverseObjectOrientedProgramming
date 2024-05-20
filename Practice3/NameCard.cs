using System;
class NameCard
{
    private string name;
    private string phoneNumber;
    private string address;
    private string rank;
    
    public NameCard(string name, string phoneNumber, string address, string rank)
    {
        this.name = name;
        this.phoneNumber = phoneNumber;
        this.address = address;
        this.rank = rank;
    }

    public void ShowData()
    {
        Console.WriteLine(
            $" 이\t름: {name}\n 전화번호: {phoneNumber}\n 주\t소: {address}\n 직\t급: {rank}");
    }
}
