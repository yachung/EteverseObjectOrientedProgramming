class Program
{
    static void Main(string[] args)
    {
        // NameCard(이름, 전화번호, 주소, 직급);
        NameCard jang = new NameCard("Jang Se Yun", "010-1111-1111", "서울시...", "Freelancer");
        jang.ShowData();
    }
}