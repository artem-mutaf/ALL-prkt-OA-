using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tema19prkt4_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pass> register = new List<Pass>();

            // Считываем информацию из файла и заполняем коллекцию register
            FillRegisterFromFile("passes.txt", register);

            // Выводим информацию о пропусках
            Console.WriteLine("Информация о пропусках:");
            foreach (var pass in register)
            {
                pass.DisplayInfo();
                Console.WriteLine();
            }

            // Выводим информацию о пропусках, которые должны быть аннулированы
            Console.WriteLine("\nПропуски, которые должны быть аннулированы:");
            foreach (var pass in register)
            {
                if (pass is StudentPass studentPass && CheckIfStudentFinishedStudies(studentPass))
                {
                    studentPass.CancelPass();
                    studentPass.DisplayInfo();
                    Console.WriteLine();
                }
                else if (pass is BuilderPass builderPass && CheckIfBuilderFinishedWork(builderPass))
                {
                    builderPass.CancelPass();
                    builderPass.DisplayInfo();
                    Console.WriteLine();
                }
            }

            // Выводим информацию о пропусках, которые должны быть обновлены
            Console.WriteLine("\nПропуски, которые должны быть обновлены:");
            foreach (var pass in register)
            {
                if (pass is TeacherPass)
                {
                    (pass as TeacherPass).UpdatePass();
                    pass.DisplayInfo();
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }

        // Метод для проверки завершил ли студент учебу
        static bool CheckIfStudentFinishedStudies(StudentPass studentPass)
        {
            int currentYear = DateTime.Now.Year;
            return (currentYear - studentPass.EnrollmentYear) >= 4; // Предположим, что учеба длится 4 года
        }

        // Метод для проверки завершил ли строитель работу
        static bool CheckIfBuilderFinishedWork(BuilderPass builderPass)
        {
            return DateTime.Now > builderPass.EndDate;
        }

        // Метод для заполнения коллекции register данными из файла
        static void FillRegisterFromFile(string filePath, List<Pass> register)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(';');
                        switch (data[0])
                        {
                            case "Teacher":
                                register.Add(new TeacherPass(data[1], data[2], data[3], data[4], data[5]));
                                break;
                            case "Student":
                                register.Add(new StudentPass(data[1], data[2], data[3], data[4], int.Parse(data[5])));
                                break;
                            case "Builder":
                                register.Add(new BuilderPass(data[1], data[2], data[3], data[4], DateTime.Parse(data[5]), DateTime.Parse(data[6])));
                                break;
                            default:
                                Console.WriteLine("Неизвестный тип пропуска.");
                                break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка при чтении файла: {e.Message}");
            }
            Console.ReadLine();
        }
    }
}
