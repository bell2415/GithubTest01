namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
                      //1. 변수선언 및 입력부
            Console.Write("가로값을 입력해 주세요 : ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("가로값을 입력해 주세요 : ");
            int height = int.Parse(Console.ReadLine());

            //2. 알고리즘 수식
            int result = width * height; // 수식

            //3. 출력부
            Console.WriteLine($"넓이는 {result} 입니다.");

        }
    }
}
