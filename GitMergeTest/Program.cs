using System;

namespace GitMergeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ruler ruler = new Ruler(10);
            ruler.Run();
        }
    }

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
}