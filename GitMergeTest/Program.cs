using System;

namespace GitMergeTest
{
    // { 2023.03.08. Ruler 클래스 코드 위치 변경 / Alpha
    public class Ruler
    {
        private const float ONE_INCH = 2.54f;
        public int Centimeter { get; set; } = 0;
        public float Inch
        {
            get { return Centimeter * ONE_INCH; }
            // { 2023.03.08. private SetInch 함수를 새로 추가함. / Gamma
            private set { this.SetInch(value); }
        }

        public Ruler(int cmValue)
        {
            Centimeter = cmValue;
        }

        public void Run()
        {
            Console.WriteLine($"{this.Centimeter}cm 는 {this.Inch}inch 입니다.");
        }
        private void SetInch(float inchValue) { Centimeter = (int)(inchValue / ONE_INCH); }
            // } 2023.03.08. private SetInch 함수를 새로 추가함. / Gamma
    }
    // } 2023.03.08. Ruler 클래스 코드 위치 변경 / Alpha
    internal class Program
    {
        static void Main(string[] args)
        {
            // { 2023.03.08 유저 입력 기능을 추가함. / Beta
            string userInput = string.Empty;
            Console.WriteLine("이 프로그램은 Cm 를 Inch 로 변환하는 프로그램 입니다.");
            Console.Write("Cm 값을 입력 : ");
            userInput = Console.ReadLine();

            int cmInput = 0;
            int.TryParse(userInput, out cmInput);

            Ruler ruler = new Ruler(cmInput);
            // } 2023.03.08 유저 입력 기능을 추가함. / Beta

            ruler.Run();
        }
    }
}