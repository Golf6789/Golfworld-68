using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("โปรแกรมแปลงคะแนนเป็นเกรด (พิมพ์ 'exit' เพื่อออกจากโปรแกรม)\n");

        while (true)
        {
            Console.Write("กรอกคะแนน 0-100 (หรือพิมพ์ 'exit'): ");
            string input = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("❗ ไม่ได้รับข้อมูล กรุณาลองใหม่.\n");
                continue;
            }

            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("ออกจากโปรแกรม...");
                break;
            }

            double score;
            if (!double.TryParse(input, out score))
            {
                Console.WriteLine("❗ ข้อผิดพลาด: กรุณากรอกตัวเลขหรือพิมพ์ 'exit' เพื่อออก.\n");
                continue;
            }

            if (score < 0 || score > 100)
            {
                Console.WriteLine("❗ ข้อผิดพลาด: คะแนนต้องอยู่ระหว่าง 0 ถึง 100 เท่านั้น.\n");
                continue;
            }

            int rounded = (int)Math.Round(score);

            string grade = GetGrade(rounded);

            Console.WriteLine($"\nคะแนน (ปัด): {rounded} -> เกรด: {grade}\n");

            Console.WriteLine("กด Enter เพื่อกรอกคะแนนใหม่ หรือพิมพ์ 'exit' เพื่อออก\n");
        } 
    }

    static string GetGrade(int score)
    {
        if (score >= 80 && score <= 100) return "A";
        if (score >= 75 && score <= 79) return "B+";
        if (score >= 70 && score <= 74) return "B";
        if (score >= 65 && score <= 69) return "C+";
        if (score >= 60 && score <= 64) return "C";
        if (score >= 55 && score <= 59) return "D+";
        if (score >= 50 && score <= 54) return "D";
        return "F";
    }
}
