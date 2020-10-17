using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorLib
{
    public class FunctionInsp
    {
        
            static string Workers = "Иванов И.И.Зиронов Т.А.Миронов А.В. Васильев В.И. "; // Функция вывода имени главного инспектора
            static void Main(string[] args)
            {
                Console.WriteLine(Workers);
                Console.WriteLine(GetInspector(" Васильев В.И."));
                Console.WriteLine(GetСarInspection(" Автоинспекция г. Чита"));
                Console.WriteLine(SetInspector(""));
                Console.WriteLine(GenerateNumber("100", "FF", "75"));
                Console.WriteLine(GetWorker(""));
                Console.WriteLine(AddWorker(""));
                Console.ReadLine();
            }
        /// <summary>
        /// Функция вывода на экран кто является главным инспектором 
        /// </summary>
        /// <param name="fio"></param>
        /// <returns></returns>
        public static string GetInspector(string fio)
            {
                Console.WriteLine(" Главный инспектор Васильев Василий Иванович ");
                string answer = string.Empty;
                if (fio == "Васильев В.И.")
                {
                    fio = ("Васильев В.И");
                }
                return fio;
            }
        /// <summary>
        /// Функция вывода на экран название автоинспекции
        /// </summary>
        /// <param name="inspekziya"></param>
        /// <returns></returns>
        public static string GetСarInspection(string inspekziya)
            {
            inspekziya = " Автоинспекция г. Чита ";
            Console.WriteLine($" Название - {inspekziya} ");
            return inspekziya;
            }
        /// <summary>
        /// Функция изменения имени главного инспектора
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string SetInspector(string name)
            {
                Console.WriteLine($" Сменить главного инспектора ");
                string fullname = "Васильев Василий Иванович";
                fullname = fullname.Replace(fullname, Console.ReadLine());
                Console.WriteLine($" Теперь главным инспектором является - {fullname}");
                return name;
            }
        /// <summary>
        /// Функция генерирующая госномер
        /// </summary>
        /// <param name=" integer,chars,code"></param>
        /// <returns></returns>
        public static string GenerateNumber(string integer, string chars, string code)
            {
            integer = "100";
            chars = "FF";
            code = "75";
  
            Console.WriteLine($" Ваш госномер - ");
                string answer = string.Empty;
                if (code == "75")
                {
                Console.WriteLine($"{chars + integer + code}");
                }
                else
                {
                Console.WriteLine("Не удалось");

                }
                return answer;

            }
        /// <summary>
        ///  Функция вывода списка инспекторов
        /// </summary>
        /// <param name="cpicok"></param>
        /// <returns></returns>
        public static string GetWorker(string cpicok)
            {
                Console.WriteLine($" Полный список инспекторов:  {Workers}");
                return cpicok;
            }
        /// <summary>
        /// Функция добавления нового сотрудника
        /// </summary>
        /// <param name="FIO"></param>
        /// <returns></returns>
        public static string AddWorker(string FIO)
            {
            Console.WriteLine(" Добавить нового сотрудника в список ");             
            FIO = Console.ReadLine();
            Console.WriteLine($" Новый сотрудник добавлен в список: {Workers} { FIO}");
                return FIO;
            }
        }
    }



